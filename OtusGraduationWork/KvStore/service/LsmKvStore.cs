using OtusGraduationWork.KvStore.collections;
using OtusGraduationWork.KvStore.diagnostic;
using OtusGraduationWork.KvStore.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace OtusGraduationWork.KvStore.service
{
    public sealed class LsmKvStore : IDisposable
    {
        public static string TABLE = ".table";
        public static string LOG = "log";
        public static string LOG_TMP = "logTmp";

        private string _dataDir;
        private int _partSize;
        private int _logLimit;

        private int _indexLength;
        private int _indexLimit;
        private ReaderWriterLockSlim _indexLock;
        private RedBlackTree<string, Command> _index;
        private RedBlackTree<string, Command> _immutableIndex;
        private LinkedList<SsTable> _ssTables;

        private FileStream _logStream;
        private string LogFilePath 
        { 
            get { return Path.Combine(_dataDir, LOG); } 
        }
        private string LogTmpFilePath 
        { 
            get { return Path.Combine(_dataDir, LOG_TMP); } 
        }


        public int PartSize
        {
            get { return _partSize; }
        }
        public int LogLimit
        {
            get { return _logLimit; }
        }
        public int IndexLimit
        {
            get { return _indexLimit; }
        }
        public int IndexSize
        {
            get { return _indexLength; }
        }
        public int IndexCount
        {
            get { return _index.Count; }
        }
        public int TableCount
        {
            get { return _ssTables.Count; }
        }

        public int TablesSize
        {
            get { return (int)_ssTables.Select(x => x.Meta.IndexLength + x.Meta.FilterLength).Sum(); }
        }

        public LsmKvStore(string dataDir, int partSize, int indexLimit, int logLimit)
        {
            _dataDir = dataDir;
            _partSize = partSize;
            _indexLimit = indexLimit;
            _logLimit = logLimit;

            _indexLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
            _index = new RedBlackTree<string, Command>();
            _indexLength = 0;
            _ssTables = new LinkedList<SsTable>();

            LoadFiles();
        }

        public void Dispose()
        {
            _logStream.Dispose();

            foreach (var ssTable in _ssTables)
            {
                ssTable.Dispose();
            }
        }

        public void Set(string key, byte[] value)
        {
            if (key == null)
                throw new ArgumentNullException("key");

            if (value == null)
                throw new ArgumentNullException("value");

            HandleCommand(new SetCommand(key, value));
        }

        public void Remove(string key)
        {
            if (key == null)
                throw new ArgumentNullException("key");

            HandleCommand(new RemoveCommand(key));
        }

        public byte[] Get(string key, bool filter = true)
        {
            _indexLock.EnterReadLock();
            try
            {
                OperationContext.Current.IndexSearchCount++;

                // try get from index
                var command = _index.Get(key);

                if (command!= null)
                    OperationContext.Current.IndexHitCount++;

                // try get from immutable index
                if (command == null && _immutableIndex != null)
                {
                    OperationContext.Current.ImmutableIndexSearchCount++;

                    command = _immutableIndex.Get(key);

                    if (command != null)
                        OperationContext.Current.ImmutableIndexHitCount++;
                }

                // try get from ssTables
                if (command == null)
                {
                    OperationContext.Current.SsTableSearchCount++;

                    foreach (var ssTable in _ssTables)
                    {
                        command = ssTable.Query(key, filter);
                        if (command != null)
                        {
                            OperationContext.Current.SsTableHitCount++;
                            break;
                        }
                    }
                }

                // get value is las op is set
                return (command as SetCommand)?.Value;
            }
            finally
            {
                _indexLock.ExitReadLock();
            }
        }

        private void LoadFiles()
        {
            // load tmp log
            if (File.Exists(LogTmpFilePath))
            {
                using (var stream = new FileStream(LogTmpFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    RestoreFromLog(stream);
                }
            }

            // load log
            if (File.Exists(LogFilePath))
            {
                using (var stream = new FileStream(LogFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    RestoreFromLog(stream);
                }
            }

            // load ssTables
            var fileNames = Directory.GetFiles(_dataDir, string.Format("*{0}", TABLE)).Select(x => Path.GetFileName(x)).ToList();

            var ssTableTreeMap = new RedBlackTree<long, SsTable>();

            foreach (var fileName in fileNames)
            {
                var time = long.Parse(fileName.Substring(0, fileName.IndexOf(TABLE)));
                ssTableTreeMap.Set(time, SsTable.CreateFromFile(Path.Combine(_dataDir, fileName)));
            }

            foreach (var item in ssTableTreeMap.Items())
            {
                _ssTables.AddFirst(item.Value);
            }

            // open log
            _logStream = new FileStream(LogFilePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            _logStream.Seek(0, SeekOrigin.End);
        }

        private void HandleCommand(Command command)
        {
            _indexLock.EnterWriteLock();
            try
            {
                command.Write(_logStream);
                var prevCommand = _index.Set(command.Key, command);

                _indexLength += command.Length;
                if (prevCommand != null)
                {
                    _indexLength -= prevCommand.Length;
                }

                if (_indexLength > _indexLimit || _logStream.Length > _logLimit)
                {
                    // switch index
                    _immutableIndex = _index;
                    _index = new RedBlackTree<string, Command>();
                    _indexLength = 0;

                    // log to tmp log
                    if (File.Exists(LogTmpFilePath))
                    {
                        File.Delete(LogTmpFilePath);
                    }

                    _logStream.Dispose();
                    File.Move(LogFilePath, LogTmpFilePath);

                    // flush log
                    _logStream = new FileStream(LogFilePath, FileMode.CreateNew, FileAccess.Write, FileShare.None);
                    var ssTableFileName = Path.Combine(_dataDir, string.Format("{0}{1}", DateTime.Now.Ticks, TABLE));
                    var ssTable = SsTable.CreateFromIndex(ssTableFileName, _partSize, _immutableIndex);

                    _ssTables.AddFirst(ssTable);
                    _immutableIndex = null;

                    // remove tmp log
                    if (File.Exists(LogTmpFilePath))
                    {
                        File.Delete(LogTmpFilePath);
                    }
                }
            }
            finally
            {
                _indexLock.ExitWriteLock();
            }
        }

        private void RestoreFromLog(FileStream logStream)
        {
            // load index from log
            logStream.Seek(0, SeekOrigin.Begin);

            while (logStream.Position < logStream.Length - 1)
            {
                var command = Command.Read(logStream);
                _index.Set(command.Key, command);
            }
        }
    }
}
