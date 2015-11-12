using PseudoDb.Interfaces.Metadata;
using System.Collections.Generic;

namespace PseudoDb.Interfaces.Query
{
    public interface ISchemaQuery
    {
        ICollection<Database> GetDatabases();

        bool AddDatabase(string databaseName);

        Database GetDatabase(string databaseName);

        void UpdateDatabase(string databaseName);

        void RemoveDatabase(string databaseName);
    }
}
