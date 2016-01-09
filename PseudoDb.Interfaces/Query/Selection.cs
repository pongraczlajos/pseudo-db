namespace PseudoDb.Interfaces.Query
{
    public class Selection
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

        public Selection(string table, string column)
        {
            this.table = table;
            this.column = column;
        }
    }
}
