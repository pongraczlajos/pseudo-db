using System.Collections.Generic;

namespace PseudoDb.Interfaces.Query
{
    public class Selection
    {
        private string table;

        public string Table
        {
            get { return table; }
        }

        private ICollection<string> columns;

        public ICollection<string> Columns
        {
            get { return columns; }
        }

        public Selection(string table, ICollection<string> columns)
        {
            this.table = table;
            this.columns = columns;
        }
    }
}
