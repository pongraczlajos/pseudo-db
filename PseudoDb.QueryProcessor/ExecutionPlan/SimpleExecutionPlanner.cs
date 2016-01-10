using PseudoDb.Interfaces;
using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Query;
using PseudoDb.Interfaces.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.QueryProcessor.ExecutionPlan
{
    public class SimpleExecutionPlanner : IExecutionPlanner
    {
        private Database database;

        private IRepository repository;

        private ICollection<Selection> selections;

        private ICollection<Filter> filters;

        public SimpleExecutionPlanner(Database database, IRepository repository, ICollection<Selection> selections, ICollection<Filter> filters)
        {
            this.database = database;
            this.repository = repository;
            this.selections = selections;
            this.filters = filters;
        }

        public IExecutionPlanOperation GetRootOperation()
        {
            Filter firstFilter = filters.First();

            var table = database.GetTable(firstFilter.Table);
            var readOperation = new FullScanOperation(table, repository, KeyValue.GetDatabaseFileName(database.Name), table.Name);

            var predecessor = new FilterOperation(readOperation, firstFilter);

            for (int i = 1; i < filters.Count; i++)
            {
                var operation = new FilterOperation(predecessor, filters.ElementAt(i));
                predecessor = operation;
            }

            return predecessor;
        }
    }
}
