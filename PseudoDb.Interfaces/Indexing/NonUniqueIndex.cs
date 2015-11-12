using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Indexing
{
    public class NonUniqueIndex : IConcreteIndex
    {
        private Database database;

        private Table table;

        private IRepository repository;

        private Index index;

        public NonUniqueIndex(Database database, Table table, IRepository repository, Index index)
        {
            this.database = database;
            this.table = table;
            this.repository = repository;
            this.index = index;
        }

        public bool Exists(string key)
        {
            throw new NotImplementedException();
        }

        public string Get(string key)
        {
            throw new NotImplementedException();
        }

        public void Put(string key, string value)
        {
            throw new NotImplementedException();
        }

        public void Delete(string key)
        {
            throw new NotImplementedException();
        }
    }
}
