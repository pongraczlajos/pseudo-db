using log4net;
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
        private ILog log;

        public StsDbRepository()
        {
            log4net.Config.XmlConfigurator.Configure();
            log = LogManager.GetLogger("StsDbRepository");
        }

        public bool Exists(string databaseFile, string tableName, string key)
        {
            using (IStorageEngine engine = STSdb.FromFile(databaseFile))
            {
                var table = engine.OpenXTable<string, string>(tableName);

                return table.Exists(key);
            }
        }

        public string Get(string databaseFile, string tableName, string key)
        {
            using (IStorageEngine engine = STSdb.FromFile(databaseFile))
            {
                var table = engine.OpenXTable<string, string>(tableName);

                if (table.Exists(key))
                {
                    return table[key];
                }
                else
                {
                    return null;
                }
            }
        }

        public void Put(string databaseFile, string tableName, string key, string value)
        {
            using (IStorageEngine engine = STSdb.FromFile(databaseFile))
            {
                var table = engine.OpenXTable<string, string>(tableName);

                table[key] = value;

                engine.Commit();
            }

            Log(databaseFile, tableName);
        }

        public void Delete(string databaseFile, string tableName, string key)
        {
            using (IStorageEngine engine = STSdb.FromFile(databaseFile))
            {
                var table = engine.OpenXTable<string, string>(tableName);

                table.Delete(key);

                engine.Commit();
            }

            Log(databaseFile, tableName);
        }

        private void Log(string databaseFile, string tableName)
        {
            using (IStorageEngine engine = STSdb.FromFile(databaseFile))
            {
                var table = engine.OpenXTable<string, string>(tableName);

                log.Info(string.Format("Rows in {0}.{1}:", databaseFile, tableName));

                foreach (var row in table)
                {
                    log.Info(string.Format("{0} => {1}", row.Key, row.Value));
                }
            }
        }

        public IEnumerable<KeyValuePair<string, string>> GetAll(string databaseFile, string tableName)
        {
            using (IStorageEngine engine = STSdb.FromFile(databaseFile))
            {
                var table = engine.OpenXTable<string, string>(tableName);

                foreach (var row in table)
                {
                    yield return row;
                }
            }
        }


        public void DeleteTable(string databaseFileName, string tableName)
        {
            using (IStorageEngine engine = STSdb.FromFile(databaseFileName))
            {
                engine.Delete(tableName);

                engine.Commit();
            }
        }
    }
}
