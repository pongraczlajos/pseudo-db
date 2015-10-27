using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Query
{
    public interface IQuery
    {
        void Insert(string databaseName, string tableName, string key, string value);
    }
}
