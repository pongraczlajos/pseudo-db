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
        private string databaseFileName;

        private IRepository repository;

        public IndexFactory(string databaseFileName, IRepository repository)
        {
            this.databaseFileName = databaseFileName;
            this.repository = repository;
        }

        public IConcreteIndex GetIndex(Index index)
        {
            if (index.Unique)
            {
                return new UniqueIndex(databaseFileName, repository, index);
            }
            
            return new NonUniqueIndex(databaseFileName, repository, index);
        }
    }
}
