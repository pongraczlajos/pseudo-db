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

        public Table GetTable(string tableName)
        {
            CheckTableNameIsNull(tableName);

            return Tables.Where(table => table.Name.Equals(tableName)).FirstOrDefault();
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
