using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace PseudoDb.Interfaces.Metadata
{
    public class Index
    {
        [YAXAttributeForClass()]
        public string Name { get; set; }

        [YAXAttributeForClass()]
        public bool Unique { get; set; }

        [YAXCollection(YAXCollectionSerializationTypes.Recursive, EachElementName = "IndexMember")]
        public List<string> IndexMembers { get; set; }

        public Index()
        {
            Name = string.Empty;
            Unique = false;
            IndexMembers = new List<string>();
        }
    }
}
