using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Indexing
{
    public class UniqueIndex : IConcreteIndex
    {
        private string databaseFileName;

        private IRepository repository;

        private Index index;

        public UniqueIndex(string databaseFileName, IRepository repository, Index index)
        {
            this.databaseFileName = databaseFileName;
            this.repository = repository;
            this.index = index;
        }

        public bool Exists(string key)
        {
            return repository.Exists(databaseFileName, index.Name, key);
        }

        public IEnumerable<string> Get(string key)
        {
            return new List<string>() { repository.Get(databaseFileName, index.Name, key) };
        }

        public void Put(string key, string value)
        {
            repository.Put(databaseFileName, index.Name, key, value);
        }

        public void Delete(string key)
        {
            repository.Delete(databaseFileName, index.Name, key);
        }
    }
}
