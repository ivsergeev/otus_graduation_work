using OtusGraduationWork.KvStore.collections;
using OtusGraduationWork.KvStore.diagnostic;
using OtusGraduationWork.KvStore.filters;
using System;
using System.Collections.Generic;
using System.IO;

namespace OtusGraduationWork.KvStore.model
{
    public sealed class SsTable : IDisposable
    {
        public static SsTable CreateFromFile(string filePath)
        {
            var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            //meta
            fileStream.Seek(-SsTableMeta.LENGTH, SeekOrigin.End);
            var meta = SsTableMeta.Read(fileStream);

            //index
            fileStream.Seek(meta.IndexPosition, SeekOrigin.Begin);
            var items = new List<SsTableIndexItem>();
            while(fileStream.Position < meta.IndexPosition + meta.IndexLength)
            {
                items.Add(SsTableIndexItem.Read(fileStream));
            }
            var index = new SsTableIndex(items);

            //filter
            fileStream.Seek(meta.FilterPosition, SeekOrigin.Begin);
            var filter = BloomFilter.Read(fileStream);

            return new SsTable(meta, index, filter, fileStream);
        }
        public static SsTable CreateFromIndex(string filePath, long partSize, RedBlackTree<string, Command> index)
        {
            var meta = new SsTableMeta();
            var idxItems = new List<SsTableIndexItem>();
            var filter = new BloomFilter(index.Count);

            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // data
                fileStream.Seek(0, SeekOrigin.Begin);

                var partKey = default(string);
                var partPosition = 0L;

                foreach (var item in index.Items())
                {
                    filter.Add(item.Key);

                    if (partKey == null)
                    {
                        partKey = item.Key;
                        partPosition = fileStream.Position;
                    }

                    item.Value.Write(fileStream);

                    if (fileStream.Position - partPosition > partSize)
                    {
                        idxItems.Add(new SsTableIndexItem(partKey, partPosition, fileStream.Position - partPosition));

                        partKey = null;
                        partPosition = fileStream.Position;
                    }
                }

                if (partKey != null)
                {
                    idxItems.Add(new SsTableIndexItem(partKey, partPosition, fileStream.Position - partPosition));
                }

                // index
                meta.IndexPosition = fileStream.Position;
                foreach(var idxItem in idxItems)
                {
                    idxItem.Write(fileStream);
                }
                meta.IndexLength = fileStream.Position - meta.IndexPosition;

                //filter
                meta.FilterPosition = fileStream.Position;
                filter.Write(fileStream);
                meta.FilterLength = fileStream.Position - meta.FilterPosition;

                // meta
                meta.Write(fileStream);
            }

            return new SsTable(meta, new SsTableIndex(idxItems), filter, new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read));
        }

        private SsTableMeta _meta;
        private FileStream _fileStream;
        private SsTableIndex _index;
        private BloomFilter _filter;

        public SsTableMeta Meta
        {
            get { return _meta; }
        }

        private SsTable(SsTableMeta meta, SsTableIndex index, BloomFilter filter, FileStream fileStream)
        {
            _meta = meta;
            _index = index;
            _filter = filter;
            _fileStream = fileStream;
        }
        public void Dispose()
        {
            _fileStream.Close();
        }
        public Command Query(string key, bool filter = true)
        {
            if (filter)
            {
                OperationContext.Current.SsTableFilterSearchCount++;

                if (!_filter.Contains(key))
                    return null;

                OperationContext.Current.SsTableFilterHitCount++;
            }

            OperationContext.Current.SsTableIndexSearchCount++;

            var indexItem = _index.SearchNearest(key);
            if (indexItem == null)
                return null;

            OperationContext.Current.SsTableIndexHitCount++;

            _fileStream.Seek(indexItem.Position, SeekOrigin.Begin);

            while (_fileStream.Position < indexItem.Position + indexItem.Length)
            {
                var command = Command.Read(_fileStream);
                if (command.Key == key)
                {
                    OperationContext.Current.SsTableBlockHitCount++;

                    return command;
                }
            }

            return null;
        }
    }
}
