using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Query;
using PseudoDb.QueryProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Engine
{
    public class DatabaseContext
    {
        private IMetadata metadata;

        private ISchemaQuery schemaQuery;

        public ISchemaQuery SchemaQuery
        {
            get { return schemaQuery; }
        }

        public DatabaseContext()
        {
            this.metadata = new Metadata();
            this.schemaQuery = new SchemaQuery(metadata);
        }
    }
}
