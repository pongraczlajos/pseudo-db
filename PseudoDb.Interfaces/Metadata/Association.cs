using System.Collections.Generic;
using YAXLib;

namespace PseudoDb.Interfaces.Metadata
{
    public class Association
    {
        [YAXAttributeForClass()]
        public string Name { get; set; }

        public string Parent { get; set; }

        public string Child { get; set; }

        [YAXDictionary(EachPairName = "ColumnRef", KeyName = "OnParent", ValueName = "OnChild",
                SerializeKeyAs = YAXNodeTypes.Attribute,
                SerializeValueAs = YAXNodeTypes.Attribute)]
        public Dictionary<string, string> ColumnMappings { get; set; }

        public Association()
        {
            Name = string.Empty;
            Parent = string.Empty;
            Child = string.Empty;
            ColumnMappings = new Dictionary<string, string>();
        }
    }
}
