using PseudoDb.Interfaces.Query;
using PseudoDb.Interfaces.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.QueryProcessor.ExecutionPlan
{
    class FullScanExecutionPlanOperation : IExecutionPlanOperation
    {
        public IExecutionPlanOperation Successor { get; set; }

        public IExecutionPlanOperation Predecessor { get; set; }

        private IRepository repository;

        private string databaseFile;

        private string tableName;

        public FullScanExecutionPlanOperation(IExecutionPlanOperation successor, IRepository repository, string databaseFile, string tableName)
        {
            Successor = successor;
            this.repository = repository;
        }

        public IEnumerable<KeyValuePair<string, string>> Execute()
        {
            foreach (var row in repository.GetAll(databaseFile, tableName))
            {
                yield return row;
            }
        }
    }
}
