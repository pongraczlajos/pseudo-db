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
            DataType type = DataType.Unknown;

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

        public static object ToComboType(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Integer:
                    return "Int";
                case DataType.String:
                    return "String";
                default:
                    return "Unknown";
            }
        }
    }
}
