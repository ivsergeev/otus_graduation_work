using System;
using System.IO;
using System.Text;

namespace OtusGraduationWork.KvStore.model
{
    public abstract class Command
    {
        public enum CommandType : byte
        {
            SET = 1,
            REMOVE = 2,
        }

        public abstract CommandType Type
        {
            get;
        }

        public virtual int Length
        {
            get { return Encoding.UTF8.GetByteCount(Key) + 4 + 1; }
        }

        public string Key
        {
            get;
            private set;
        }

        public Command(string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("key");

            Key = key;
        }
        public void Write(Stream stream)
        {
            using (var writer = new BinaryWriter(stream, Encoding.UTF8, true))
            {
                var keyBytes = Encoding.UTF8.GetBytes(Key);

                writer.Write((byte)Type);
                writer.Write(keyBytes.Length);
                writer.Write(keyBytes, 0, keyBytes.Length);

                WritePayload(writer);
            }
        }

        public static Command Read(Stream stream)
        {
            using (var reader = new BinaryReader(stream, Encoding.UTF8, true))
            {
                var type = reader.ReadByte();
                var keyLength = reader.ReadInt32();
                var key = Encoding.UTF8.GetString(reader.ReadBytes(keyLength));

                switch (type)
                {
                    case (byte)CommandType.SET:
                        var valueLength = reader.ReadInt32();
                        var value = reader.ReadBytes(valueLength);
                        return new SetCommand(key, value);
                    case (byte)CommandType.REMOVE:
                        return new RemoveCommand(key);
                    default:
                        throw new Exception("Invalid command type");
                }
            }
        }

        protected virtual void WritePayload(BinaryWriter writer)
        {
        }
    }

    public sealed class SetCommand : Command
    {
        public override CommandType Type
        {
            get { return CommandType.SET; }
        }

        public override int Length
        {
            get { return base.Length + Value.Length + 4; }
        }

        public byte[] Value
        {
            get;
            private set;
        }

        public SetCommand(string key, byte[] value) : base(key)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            Value = value;
        }

        protected override void WritePayload(BinaryWriter writer)
        {
            writer.Write(Value.Length);
            writer.Write(Value, 0, Value.Length);
        }
    }

    public sealed class RemoveCommand : Command
    {
        public override CommandType Type
        {
            get { return CommandType.REMOVE; }
        }
        public RemoveCommand(string key) : base(key)
        {
        }
    }
}