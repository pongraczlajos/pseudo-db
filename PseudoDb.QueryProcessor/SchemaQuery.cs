using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Query;
using PseudoDb.Interfaces.Engine;

namespace PseudoDb.QueryProcessor
{
    public class SchemaQuery : ISchemaQuery
    {
        private Database database;

        public IEngine Engine { get; set; }

        public ISchemaQuery AddDatabase(string databaseName)
        {
            return this;
        }

        public ISchemaQuery GetDatabase(string databaseName)
        {
            return this;
        }

        public ISchemaQuery DeleteDatabase(string databaseName)
        {
            return this;
        }

        public ISchemaQuery AddTable(string databaseName, string tableName)
        {
            return this;
        }

        public ISchemaQuery GetTable(string databaseName, string tableName)
        {
            return this;
        }

        public ISchemaQuery DeleteTable(string databaseName, string tableName)
        {
            return this;
        }

        public ISchemaQuery AddOrUpdateColumn(string databaseName, string tableName,
            string columnName, DataType type, int size, bool nullable = false)
        {
            return this;
        }

        public ISchemaQuery DeleteColumn(string databaseName, string tableName, string columnName)
        {
            return this;
        }

        public Database Execute()
        {
            return database;
        }
    }
}
