using System.Collections.Generic;

namespace PseudoDb.ClientDesktop.Model
{
    class Association
    {
        public string Name { get; set; }

        public string ParentTable { get; set; }

        public string ChildTable { get; set; }

        public Dictionary<string, string> ColumnMappings { get; set; }

        public Association()
        {
            Name = string.Empty;
            ParentTable = string.Empty;
            ChildTable = string.Empty;
            ColumnMappings = new Dictionary<string, string>();
        }
    }
}
