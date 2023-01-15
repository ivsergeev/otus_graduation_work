using System.IO;
using System.Text;

namespace OtusGraduationWork.KvStore.model
{
    public class SsTableMeta
    {
        public long IndexPosition
        {
            get; 
            set;
        }
        public long IndexLength
        {
            get;
            set;
        }
        public long FilterPosition
        {
            get;
            set;
        }
        public long FilterLength
        {
            get;
            set;
        }

        public void Write(Stream stream)
        {
            using (var writer = new BinaryWriter(stream, Encoding.UTF8, true))
            {
                writer.Write(IndexPosition);
                writer.Write(IndexLength);
                writer.Write(FilterPosition);
                writer.Write(FilterLength);
            }
        }

        public static int LENGTH
        {
            get { return 32; }
        }

        public static SsTableMeta Read(Stream stream)
        {
            using (var reader = new BinaryReader(stream, Encoding.UTF8, true))
            {
                return new SsTableMeta()
                {
                    IndexPosition = reader.ReadInt64(),
                    IndexLength = reader.ReadInt64(),
                    FilterPosition = reader.ReadInt64(),
                    FilterLength = reader.ReadInt64(),
                };
            }
        }
    }
}
