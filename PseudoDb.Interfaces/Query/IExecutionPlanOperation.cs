using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Query
{
    public interface IExecutionPlanOperation
    {
        IExecutionPlanOperation Successor { get; set; }

        IExecutionPlanOperation Predecessor { get; set; }

        IEnumerable<KeyValuePair<string, string>> Execute();
    }
}
