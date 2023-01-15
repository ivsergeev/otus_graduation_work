using System.IO;
using System.Text;

namespace OtusGraduationWork.KvStore.model
{
    public class SsTableIndexItem
    {
        public string Key
        {
            get; set;
        }
        public long Position 
        {
            get; set;
        }
        public long Length 
        {
            get; set;        
        }

        public SsTableIndexItem(string key, long position, long length)
        {
            Key = key;
            Position = position;
            Length = length;
        }

        public void Write(Stream stream)
        {
            using (var writer = new BinaryWriter(stream, Encoding.UTF8, true))
            {
                var keyBytes = Encoding.UTF8.GetBytes(Key);

                writer.Write(keyBytes.Length);
                writer.Write(keyBytes, 0, keyBytes.Length);
                writer.Write(Position);
                writer.Write(Length);
            }
        }

        public static SsTableIndexItem Read(Stream stream)
        {
            using(var reader = new BinaryReader(stream, Encoding.UTF8, true))
            {
                var keyLength = reader.ReadInt32();
                var key = Encoding.UTF8.GetString(reader.ReadBytes(keyLength));
                var position = reader.ReadInt64();
                var length = reader.ReadInt64();

                return new SsTableIndexItem(key, position, length);
            }
        }
    }
}
