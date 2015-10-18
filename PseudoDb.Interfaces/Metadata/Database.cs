using System;
using System.Collections.Generic;
using System.Linq;
using YAXLib;

namespace PseudoDb.Interfaces.Metadata
{
    public class Database
    {
        [YAXAttributeForClass()]
        public string Name { get; set; }

        [YAXCollection(YAXCollectionSerializationTypes.Recursive)]
        public List<Table> Tables { get; set; }

        [YAXCollection(YAXCollectionSerializationTypes.Recursive)]
        public List<Association> Associations { get; set; }

        public Database()
        {
            Name = string.Empty;
            Tables = new List<Table>();
            Associations = new List<Association>();
        }

        public Database(String Name)
        {
            this.Name = Name;
            Tables = new List<Table>();
            Associations = new List<Association>();
        }

        public void AddTable(string tableName)
        {
            Table table = new Table();
            table.Name = tableName;

            Tables.Add(table);
        }

        public Table GetTable(string tableName)
        {
            CheckTableNameIsNull(tableName);

            return Tables.Where(table => table.Name.Equals(tableName)).FirstOrDefault();
        }

        public void RemoveTable(string tableName)
        {
            Table table = Tables.Where(t => t.Name.Equals(tableName)).FirstOrDefault();

            if (table != null)
            {
                Tables.Remove(table);
            }
        }

        public void AddAssociation(string associationName, string parent, string child,
            Dictionary<string, string> mappings)
        {
            Association association = new Association();
            association.Name = associationName;
            association.Parent = parent;
            association.Child = child;

            foreach (var mapping in mappings)
            {
                association.ColumnMappings[mapping.Key] = mapping.Value;
            }

            Associations.Add(association);
        }

        public Association GetAssociation(string associationName)
        {
            return Associations.Where(a => a.Name.Equals(associationName)).FirstOrDefault();
        }

        public void RemoveAssociation(string associationName)
        {
            Association association = Associations.Where(a => a.Name.Equals(associationName)).FirstOrDefault();

            if (association != null)
            {
                Associations.Remove(association);
            }
        }

        public IEnumerable<Association> GetAssociationsWhereTableIsParent(string tableName)
        {
            CheckTableNameIsNull(tableName);

            return Associations.Where(association => association.Parent.Equals(tableName));
        }

        public IEnumerable<Association> GetAssociationsWhereTableIsChild(string tableName)
        {
            CheckTableNameIsNull(tableName);

            return Associations.Where(association => association.Child.Equals(tableName));
        }

        private void CheckTableNameIsNull(string tableName)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException("The table name object is null!");
            }
        }
    }
}
