using System.Collections.Generic;

namespace PseudoDb.ClientDesktop.Model
{
    public class Table
    {
        public string Name { get; set; }

        public List<string> PrimaryKey { get; set; }

        public List<Column> Columns { get; set; }

        public Table()
        {
            Name = string.Empty;
            PrimaryKey = new List<string>();
            Columns = new List<Column>();
        }

        public Table(string Name)
        {
            this.Name = Name;
            PrimaryKey = new List<string>();
            Columns = new List<Column>();
        }
    }
}
