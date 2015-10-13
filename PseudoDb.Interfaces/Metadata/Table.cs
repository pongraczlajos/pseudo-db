using System.Collections.Generic;
using YAXLib;
namespace PseudoDb.Interfaces.Metadata
{
    public class Table
    {
        [YAXAttributeForClass()]
        public string Name { get; set; }

        [YAXCollection(YAXCollectionSerializationTypes.Recursive, EachElementName = "KeyMember")]
        public List<string> PrimaryKey { get; set; }

        [YAXCollection(YAXCollectionSerializationTypes.Recursive)]
        public List<Column> Columns { get; set; }

        public Table()
        {
            Name = string.Empty;
            PrimaryKey = new List<string>();
            Columns = new List<Column>();
        }

        public void AddOrUpdateColumn(string columnName, DataType type, int size, bool nullable = false)
        {
            if (Columns.Exists(c => c.Name.Equals(columnName)))
            {
                Column column = Columns.Find(c => c.Name.Equals(columnName));
                column.Type = type;
                column.Size = size;
                column.Nullable = nullable;
            }
            else
            {
                Column column = new Column();
                column.Name = columnName;
                column.Type = type;
                column.Size = size;
                column.Nullable = nullable;

                Columns.Add(column);
            }
        }

        public Column GetColumn(string columnName)
        {
            if (Columns.Exists(c => c.Name.Equals(columnName)))
            {
                return Columns.Find(c => c.Name.Equals(columnName));
            }

            return null;
        }

        public void DeleteColumn(string columnName)
        {
            if (Columns.Exists(c => c.Name.Equals(columnName)))
            {
                Column column = Columns.Find(c => c.Name.Equals(columnName));
                Columns.Remove(column);
            }
        }
    }
}
