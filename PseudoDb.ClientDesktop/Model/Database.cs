using System.Collections.Generic;

namespace PseudoDb.ClientDesktop.Model
{
    class Database
    {
        public string Name { get; set; }

        public List<Table> Tables { get; set; }

        public List<Association> Relationships { get; set; }

        public Database()
        {
            Name = string.Empty;
            Tables = new List<Table>();
            Relationships = new List<Association>();
        }

        public Database(string Name)
        {
            this.Name = Name;
            Tables = new List<Table>();
            Relationships = new List<Association>();
        }
    }
}
