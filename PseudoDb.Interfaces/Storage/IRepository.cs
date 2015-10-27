using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Storage
{
    public interface IRepository
    {
        void Exists(string databaseName, string tableName, string key);

        void Get(string databaseName, string tableName, string key);

        void Put(string databaseName, string tableName, string key, string value);
    }
}
