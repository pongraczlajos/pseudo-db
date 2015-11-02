using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Metadata
{
    public enum Operator
    {
        Equal,
        NotEqual,
        Less,
        Greater,
        LessOrEqual,
        GreaterOrEqual
    }

    public static class OperatorConverter
    {
        public static Operator ToOperator(string op)
        {
            switch (op)
            {
                case "=":
                    return Operator.Equal;
                case "<>":
                    return Operator.NotEqual;
                case "<":
                    return Operator.Less;
                case ">":
                    return Operator.Greater;
                case "<=":
                    return Operator.LessOrEqual;
                case ">=":
                    return Operator.GreaterOrEqual;
                default:
                    return Operator.Equal;
            }
        }

        public static object ToComboString(Operator op)
        {
            switch (op)
            {
                case Operator.Equal:
                    return "=";
                case Operator.NotEqual:
                    return "<>";
                case Operator.Less:
                    return "<";
                case Operator.Greater:
                    return ">";
                case Operator.LessOrEqual:
                    return "<=";
                case Operator.GreaterOrEqual:
                    return ">=";
                default:
                    return "=";
            }
        }
    }
}
