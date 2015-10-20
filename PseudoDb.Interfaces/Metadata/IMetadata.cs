using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Metadata
{
    public interface IMetadata
    {
        ICollection<Database> GetDatabases();

        Database GetDatabase(string databaseName);

        void AddDatabase(string databaseName);

        void UpdateDatabase(string databaseName);

        void RemoveDatabase(string databaseName);
    }
}
