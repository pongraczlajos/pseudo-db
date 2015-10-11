using PseudoDb.Interfaces.Metadata;
using System;

namespace PseudoDb.QueryProcessor
{
    public class SchemaQuery
    {
        public SchemaQuery()
        {
        }

        public bool AddDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public Database GetDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public bool AddTable(string databaseName, string tableName)
        {
            throw new NotImplementedException();
        }

        public Table GetTable(string databaseName, string tableName)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTable(string databaseName, string tableName)
        {
            throw new NotImplementedException();
        }

        public bool AddOrUpdateColumn(string databaseName, string tableName, 
            string columnName, DataType type, int size, bool nullable = false)
        {
            throw new NotImplementedException();
        }

        public bool DeleteColumn(string databaseName, string tableName, string columnName)
        {
            throw new NotImplementedException();
        }
    }
}
