namespace PseudoDb.ClientDesktop.Model
{
    class Column
    {
        public string Name { get; set; }

        public DataType Type { get; set; }

        public int Size { get; set; }

        public bool Nullable { get; set; }

        public Column()
        {
            Name = string.Empty;
            Type = DataType.Unknown;
            Size = 0;
        }
    }
}
