using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Query
{
    public interface IExecutionPlanOperation
    {
        IExecutionPlanOperation Predecessor { get; set; }

        IEnumerable<KeyValuePair<string, string>> Execute();

        KeyValuePair<string, string> GetMetadata();
    }
}
