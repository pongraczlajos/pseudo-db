using System.Collections.Generic;

namespace PseudoDb.ClientDesktop.Model
{
    class Table
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
    }
}
