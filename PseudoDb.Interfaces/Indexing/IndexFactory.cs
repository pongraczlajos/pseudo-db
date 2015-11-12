using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Indexing
{
    public class IndexFactory
    {
        private Database database;

        private Table table;

        private IRepository repository;

        public IndexFactory(Database database, Table table, IRepository repository)
        {
            this.database = database;
            this.table = table;
            this.repository = repository;
        }

        public IConcreteIndex GetIndex(Index index)
        {
            if (index.Unique)
            {
                return new UniqueIndex(database, table, repository, index);
            }
            
            return new NonUniqueIndex(database, table, repository, index);
        }
    }
}
