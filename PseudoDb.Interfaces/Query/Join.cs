namespace PseudoDb.Interfaces.Query
{
    public class Join
    {
        private string leftTable;

        public string LeftTable
        {
            get { return leftTable; }
        }

        private string leftColumn;

        public string LeftColumn
        {
            get { return leftColumn; }
        }

        private string rightTable;

        public string RightTable
        {
            get { return rightTable; }
        }

        private string rightColumn;

        public string RightColumn
        {
            get { return rightColumn; }
        }

        public Join(string leftTable, string leftColumn, string rightTable, string rightColumn)
        {
            this.leftTable = leftTable;
            this.leftColumn = leftColumn;
            this.rightTable = rightTable;
            this.rightColumn = rightColumn;
        }
    }
}
