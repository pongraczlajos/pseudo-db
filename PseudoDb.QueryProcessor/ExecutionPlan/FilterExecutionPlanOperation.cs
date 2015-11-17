using PseudoDb.Interfaces;
using PseudoDb.Interfaces.Metadata;
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
        public IExecutionPlanOperation Predecessor { get; set; }

        private Filter filter;

        private KeyValuePair<string, string> metadata;

        public FilterExecutionPlanOperation(IExecutionPlanOperation predecessor, Filter filter)
        {
            Predecessor = predecessor;
            this.filter = filter;
            this.metadata = Predecessor.GetMetadata();
        }

        public IEnumerable<KeyValuePair<string, string>> Execute()
        {
            // Determine where the filtered column is (is it part of the key, or is it part of the value).
            var primaryKey = KeyValue.Split(metadata.Key).ToArray();
            var columns = KeyValue.Split(metadata.Value).ToArray();

            var filteredColumnInKey = primaryKey.Contains(filter.Column);
            int filteredColumnIndex = 0;

            if (filteredColumnInKey)
            {
                for (int i = 0; i < primaryKey.Count(); i++)
                {
                    if (filter.Column.Equals(primaryKey[i]))
                    {
                        filteredColumnIndex = i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < columns.Count(); i++)
                {
                    if (filter.Column.Equals(columns[i]))
                    {
                        filteredColumnIndex = i;
                        break;
                    }
                }
            }

            foreach (var row in Predecessor.Execute())
            {
                // Get the value of the column.
                var columnValue = string.Empty;

                if (filteredColumnInKey)
                {
                    columnValue = KeyValue.Split(row.Key).ToArray()[filteredColumnIndex];
                }
                else
                {
                    columnValue = KeyValue.Split(row.Value).ToArray()[filteredColumnIndex];
                }

                // Check if it satisfies the filter condition.
                int comparision = columnValue.CompareTo(filter.Value);

                switch (filter.Operator)
                {
                    case Operator.Equal:
                        if (comparision == 0)
                        {
                            yield return row;
                        }
                        break;
                    case Operator.NotEqual:
                        if (comparision != 0)
                        {
                            yield return row;
                        }
                        break;
                    case Operator.Less:
                        if (comparision < 0)
                        {
                            yield return row;
                        }
                        break;
                    case Operator.Greater:
                        if (comparision > 0)
                        {
                            yield return row;
                        }
                        break;
                    case Operator.LessOrEqual:
                        if (comparision <= 0)
                        {
                            yield return row;
                        }
                        break;
                    case Operator.GreaterOrEqual:
                        if (comparision >= 0)
                        {
                            yield return row;
                        }
                        break;
                }
            }
        }

        public KeyValuePair<string, string> GetMetadata()
        {
            return metadata;
        }
    }
}
