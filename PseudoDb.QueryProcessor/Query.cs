using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Query;
using PseudoDb.Interfaces.Storage;
using System;
using System.Collections.Generic;
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
    }
}
