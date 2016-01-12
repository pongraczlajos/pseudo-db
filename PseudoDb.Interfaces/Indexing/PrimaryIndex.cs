using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Storage;
using System.Collections.Generic;

namespace PseudoDb.Interfaces.Indexing
{
    public class PrimaryIndex : IConcreteIndex
    {
        private string databaseFileName;

        private Table table;

        private IRepository repository;

        public PrimaryIndex(Table table, string databaseFileName, IRepository repository)
        {
            this.table = table;
            this.databaseFileName = databaseFileName;
            this.repository = repository;
        }

        public bool Exists(string key)
        {
            return repository.Exists(databaseFileName, table.Name, key);
        }

        public IEnumerable<string> Get(string key)
        {
            return new List<string>() { repository.Get(databaseFileName, table.Name, key) };
        }

        public void Delete(string key)
        {
            
        }

        public void Delete(string key, string subKey)
        {
            
        }

        public void Put(string key, string value)
        {
            
        }
    }
}
