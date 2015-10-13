using PseudoDb.Interfaces.Metadata;

namespace PseudoDb.Interfaces.Engine
{
    public interface IEngine
    {
        void AddDatabase(string databaseName);

        Database GetDatabase(string databaseName);

        void RemoveDatabase(string databaseName);

        void Execute(Database database);
    }
}
