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
        public static PseudoDb.Interfaces.Metadata.DataType ToDataType(String typeName)
        {
            PseudoDb.Interfaces.Metadata.DataType type = PseudoDb.Interfaces.Metadata.DataType.Unknown;
            switch (typeName)
            {
                case "Int":
                    type = PseudoDb.Interfaces.Metadata.DataType.Integer;
                    break;
                case "String":
                    type = PseudoDb.Interfaces.Metadata.DataType.String;
                    break;
            }
            return type;
        }

    }
}
