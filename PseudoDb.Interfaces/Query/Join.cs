using PseudoDb.Interfaces.Metadata;

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

        private Operator op;

        public Operator Operator
        {
            get { return op; }
        }

        public Join(string leftTable, string leftColumn, string rightTable, string rightColumn, Operator op)
        {
            this.leftTable = leftTable;
            this.leftColumn = leftColumn;
            this.rightTable = rightTable;
            this.rightColumn = rightColumn;
            this.op = op;
        }
    }
}
