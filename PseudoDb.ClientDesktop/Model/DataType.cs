using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.ClientDesktop.Model
{
    public enum DataType
    {
        Unknown,
        Int,
        String
    }

    public static class DataTypeConverter
    {
        public static DataType ToDataType(String typeName)
        {
            DataType type = DataType.Unknown;
            switch (typeName)
            {
                case "Int":
                    type = DataType.Int;
                    break;
                case "String":
                    type = DataType.String;
                    break;
            }
            return type;
        }
    }
}
