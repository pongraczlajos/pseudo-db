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

        public void Insert(Database database, Table table, ICollection<string> keyMembers, ICollection<string> values)
        {
            string stsDbFile = string.Format("{0}.stsdb4", database.Name);
            string key = string.Join("#", keyMembers);
            string value = string.Join("#", values);

            // Insert indexes.

            // Insert row.
            repository.Put(stsDbFile, table.Name, key, value);
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
