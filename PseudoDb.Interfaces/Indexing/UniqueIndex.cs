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
        private Database database;

        private Table table;

        private IRepository repository;

        private Index index;

        public UniqueIndex(Database database, Table table, IRepository repository, Index index)
        {
            this.database = database;
            this.table = table;
            this.repository = repository;
            this.index = index;
        }

        public bool Exists(string key)
        {
            string stsDbFile = string.Format("{0}.stsdb4", database.Name);
            return true;
        }

        public string Get(string key)
        {
            string stsDbFile = string.Format("{0}.stsdb4", database.Name);
            return "";
        }

        public void Put(string key, string value)
        {
            string stsDbFile = string.Format("{0}.stsdb4", database.Name);
            //string key = string.Join("#", keyMembers);
            //string value = string.Join("#", values);

            repository.Put(stsDbFile, index.Name, key, value);
        }

        public void Delete(string key)
        {
            string stsDbFile = string.Format("{0}.stsdb4", database.Name);
        }
    }
}
