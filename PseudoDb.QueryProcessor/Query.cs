using PseudoDb.Interfaces;
using PseudoDb.Interfaces.Indexing;
using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Query;
using PseudoDb.Interfaces.Storage;
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
            string stsDbFile = string.Format("{0}.stsdb4", database.Name);
            string key = string.Join("#", keyMembers);
            string value = string.Join("#", values);

            ReturnStatus status = new ReturnStatus();

            // Check primary key and unique index constraints.
            if (repository.Exists(stsDbFile, table.Name, key))
            {
                status.ReturnCode = ReturnCode.PrimaryKeyConstraintFailed;
                status.Message = string.Format("Primary key constraint check failed for primary key: {0}", key);

                return status;
            }

            var indexFactory = new IndexFactory(database, table, repository);

            foreach (var uniqueIndex in table.Indexes.Where(i => i.Unique))
            {
                var index = indexFactory.GetIndex(uniqueIndex);
            }

            // Insert indexes.

            // Insert row if there is no errors.
            repository.Put(stsDbFile, table.Name, key, value);

            return status;
        }

        public DataTable GetAll(Database database, Table table)
        {
            DataTable result = new DataTable();
            string stsDbFile = string.Format("{0}.stsdb4", database.Name);
            var queryResult = repository.GetAll(stsDbFile, table.Name);
            
            foreach(var item in table.Columns)
            {
                result.Columns.Add(item.Name, typeof(string));
            }

            foreach(var pair in queryResult)
            {
                List<string> row = new List<string>();
                row.AddRange(pair.Key.Split('#').ToArray());
                row.AddRange(pair.Value.Split('#').ToArray());

                result.Rows.Add(row.ToArray());
            }

            return result;
            
        }
    }
}
