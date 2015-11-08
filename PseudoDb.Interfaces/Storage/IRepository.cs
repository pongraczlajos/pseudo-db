using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Storage
{
    public interface IRepository
    {
        bool Exists(string databaseFile, string tableName, string key);

        string Get(string databaseFile, string tableName, string key);

        void Put(string databaseFile, string tableName, string key, string value);

        void Delete(string databaseFile, string tableName, string key);

        List<KeyValuePair<string, string>> GetAll(string databaseFile, string tableName);
    }
}
