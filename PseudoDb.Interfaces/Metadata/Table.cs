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
    }
}
