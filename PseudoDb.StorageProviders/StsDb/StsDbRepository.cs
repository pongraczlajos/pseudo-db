using PseudoDb.Interfaces.Storage;
using STSdb4.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.StorageProviders.StsDb
{
    public class StsDbRepository : IRepository
    {
        public void Exists(string databaseName, string tableName, string key)
        {

        }

        public void Get(string databaseName, string tableName, string key)
        {
            using (IStorageEngine engine = STSdb.FromFile(databaseName))
            {
                var table = engine.OpenXTable<Key, Value>(tableName);
            }
        }

        public void Put(string databaseName, string tableName, string key, string value)
        {
            using (IStorageEngine engine = STSdb.FromFile(databaseName))
            {
                var table = engine.OpenXTable<Key, Value>(tableName);
            }
        }
    }
}
