using PseudoDb.Interfaces.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.QueryProcessor.ExecutionPlan
{
    public interface IExecutionPlanner
    {
        IExecutionPlanOperation GetRootOperation();
    }
}
