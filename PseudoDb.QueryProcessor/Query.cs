using PseudoDb.Interfaces;
using PseudoDb.Interfaces.Indexing;
using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Query;
using PseudoDb.Interfaces.Storage;
using PseudoDb.QueryProcessor.ExecutionPlan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.QueryProcessor
{
    public class Query : IQuery
    {
        private IRepository repository;

        public Query(IRepository repository)
        {
            this.repository = repository;
        }

        public ReturnStatus Insert(Database database, Table table, ICollection<string> keyMembers, ICollection<string> values)
        {
            string databaseFileName = KeyValue.GetDatabaseFileName(database.Name);
            string key = KeyValue.Concatenate(keyMembers);
            string value = KeyValue.Concatenate(values);

            ReturnStatus status = new ReturnStatus();

            // Check primary key constraints.
            if (repository.Exists(databaseFileName, table.Name, key))
            {
                status.ReturnCode = ReturnCode.PrimaryKeyConstraintFailed;
                status.Message = string.Format("Primary key constraint check failed for primary key: {0}", key);

                return status;
            }

            // Check unique index constraints.
            var uniqueIndexes = new IConcreteIndex[table.Indexes.Where(i => i.Unique).Count()];
            var uniqueIndexKeys = new string[table.Indexes.Where(i => i.Unique).Count()];

            var indexFactory = new IndexFactory(databaseFileName, repository);

            var counter = 0;
            var nonKeyColumnNames = table.Columns.Where(c => !table.PrimaryKey.Contains(c.Name)).Select(c => c.Name).ToList();

            foreach (var uniqueIndex in table.Indexes.Where(i => i.Unique))
            {
                var index = indexFactory.GetIndex(uniqueIndex);
                uniqueIndexes[counter] = index;

                var columnValues = new List<string>();

                foreach (var column in uniqueIndex.IndexMembers)
                {
                    columnValues.Add(values.ElementAt(nonKeyColumnNames.IndexOf(column)));
                }

                var uniqueKey = KeyValue.Concatenate(columnValues);
                uniqueIndexKeys[counter] = uniqueKey;

                if (index.Exists(uniqueKey))
                {
                    status.ReturnCode = ReturnCode.UniqueConstraintFailed;
                    status.Message = string.Format("Unique constraint check failed for key: {0}", uniqueKey);

                    return status;
                }

                counter++;
            }

            // Check foreign key constraints.

            // Insert indexes.
            for (int k = 0; k < uniqueIndexes.Length; k++)
            {
                uniqueIndexes[k].Put(uniqueIndexKeys[k], key);
            }

            // Insert row if there is no errors.
            repository.Put(databaseFileName, table.Name, key, value);

            status.ReturnCode = ReturnCode.Success;
            status.Message = string.Format("({0} row(s) affected)", 1);

            return status;
        }

        public ReturnStatus Delete(Database database, Table table, ICollection<Filter> filters)
        {
            var planner = new SimpleExecutionPlanner(database, repository, new List<Selection>(), filters);
            var rootOperation = planner.GetRootOperation();

            var rows = rootOperation.Execute();

            var rowsToDelete = new List<string>();
            foreach (var row in rows)
            {
                rowsToDelete.Add(row.Key);
            }

            foreach (var rowToDelete in rowsToDelete)
            {
                repository.Delete(KeyValue.GetDatabaseFileName(database.Name), table.Name, rowToDelete);
            }

            ReturnStatus status = new ReturnStatus();
            status.ReturnCode = ReturnCode.Success;
            status.Message = string.Format("({0} row(s) affected)", rowsToDelete.Count);

            return status;
        }

        public DataTable GetAll(Database database, Table table)
        {
            DataTable result = new DataTable();
            string databaseFileName = KeyValue.GetDatabaseFileName(database.Name);
            var queryResult = repository.GetAll(databaseFileName, table.Name);
            
            foreach(var item in table.Columns)
            {
                result.Columns.Add(item.Name, typeof(string));
            }

            foreach (var pair in queryResult)
            {
                List<string> row = new List<string>();
                row.AddRange(KeyValue.Split(pair.Key));
                row.AddRange(KeyValue.Split(pair.Value));

                result.Rows.Add(row.ToArray());
            }

            return result;
            
        }

        public void DeleteTable(Database database, Table table)
        {
            string databaseFileName = KeyValue.GetDatabaseFileName(database.Name);

            // Remove all index tables.
            foreach (var indexName in table.Indexes.Select(i => i.Name))
            {
                repository.DeleteTable(databaseFileName, indexName);
            }

            // Remove table.
            repository.DeleteTable(databaseFileName, table.Name);
        }
    }
}
