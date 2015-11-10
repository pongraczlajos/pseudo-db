using PseudoDb.Interfaces.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.QueryProcessor.ExecutionPlan
{
    class FilterExecutionPlanOperation : IExecutionPlanOperation
    {
        public IExecutionPlanOperation Successor { get; set; }

        public IExecutionPlanOperation Predecessor { get; set; }

        private Filter filter;

        public FilterExecutionPlanOperation(IExecutionPlanOperation predecessor, IExecutionPlanOperation successor, Filter filter)
        {
            Predecessor = predecessor;
            Successor = successor;
            this.filter = filter;
        }

        public IEnumerable<KeyValuePair<string, string>> Execute()
        {
            return ExecuteEqualityFilter();
        }

        private IEnumerable<KeyValuePair<string, string>> ExecuteEqualityFilter()
        {
            return null;
        }
    }
}
