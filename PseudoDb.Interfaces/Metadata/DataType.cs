namespace PseudoDb.Interfaces.Metadata
{
    public enum DataType
    {
        Integer,
        String,
        Unknown
    }

    public static class DataTypeConverter
    {
        public static DataType ToDataType(string typeName)
        {
            DataType type = PseudoDb.Interfaces.Metadata.DataType.Unknown;

            switch (typeName)
            {
                case "Int":
                    type = DataType.Integer;
                    break;
                case "String":
                    type = DataType.String;
                    break;
            }

            return type;
        }
    }
}
