using YAXLib;

namespace PseudoDb.Interfaces.Metadata
{
    public class Column
    {
        [YAXAttributeForClass()]
        public string Name { get; set; }

        [YAXAttributeForClass()]
        public DataType Type { get; set; }

        [YAXAttributeForClass()]
        public int Size { get; set; }

        [YAXAttributeForClass()]
        public bool Unique { get; set; }

        [YAXAttributeForClass()]
        public bool Nullable { get; set; }

        public Column()
        {
            Name = string.Empty;
            Type = DataType.Unknown;
            Size = 0;
            Unique = false;
            Nullable = false;
        }
    }
}
