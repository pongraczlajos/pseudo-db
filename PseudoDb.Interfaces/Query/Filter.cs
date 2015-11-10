using PseudoDb.Interfaces.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Query
{
    public class Filter
    {
        private string table;

        public string Table
        {
            get { return table; }
        }

        private string column;

        public string Column
        {
            get { return column; }
        }

        private Operator op;

        public Operator Operator
        {
            get { return op; }
        }

        private string value;

        public string Value
        {
            get { return value; }
        }

        public Filter(string table, string column, Operator op, string value)
        {
            this.table = table;
            this.column = column;
            this.op = op;
            this.value = value;
        }
    }
}
