using PseudoDb.Interfaces.Engine;
using PseudoDb.Interfaces.Metadata;

namespace PseudoDb.Interfaces.Query
{
    public interface ISchemaQuery
    {
        IEngine Engine { get; set; }

        ISchemaQuery AddDatabase(string databaseName);

        ISchemaQuery GetDatabase(string databaseName);

        ISchemaQuery DeleteDatabase(string databaseName);

        ISchemaQuery AddTable(string databaseName, string tableName);

        ISchemaQuery GetTable(string databaseName, string tableName);

        ISchemaQuery DeleteTable(string databaseName, string tableName);

        ISchemaQuery AddOrUpdateColumn(string databaseName, string tableName,
            string columnName, DataType type, int size, bool nullable = false);

        ISchemaQuery DeleteColumn(string databaseName, string tableName, string columnName);

        Database Execute();
    }
}
