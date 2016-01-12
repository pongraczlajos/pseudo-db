using log4net;
using PseudoDb.Interfaces;
using PseudoDb.Interfaces.Query;
using System.Collections.Generic;
using System.Linq;

namespace PseudoDb.QueryProcessor.ExecutionPlan
{
    class SelectOperation : IExecutionPlanOperation
    {
        public IExecutionPlanOperation Predecessor { get; set; }

        private Selection selection;

        private KeyValuePair<string, string> metadata;

        private ILog log;

        public SelectOperation(IExecutionPlanOperation predecessor, Selection selection)
        {
            Predecessor = predecessor;
            this.selection = selection;
            this.metadata = Predecessor.GetMetadata();

            log4net.Config.XmlConfigurator.Configure();
            log = LogManager.GetLogger("ExecutionPlan");
        }

        public IEnumerable<KeyValuePair<string, string>> Execute()
        {
            log.Info(string.Format("Select operation for '{0}'.", selection.Table));

            if (selection.Columns.Contains("*"))
            {
                foreach (var row in Predecessor.Execute())
                {
                    yield return row;
                }
            }
            else
            {
                var primaryKey = KeyValue.Split(metadata.Key).ToArray();
                var columns = KeyValue.Split(metadata.Value).ToArray();

                foreach (var row in Predecessor.Execute())
                {
                    var rowKey = KeyValue.Split(row.Key).ToArray();
                    var rowColumns = KeyValue.Split(row.Value).ToArray();

                    var newRowKey = new List<string>();
                    var newRowColumns = new List<string>();

                    for (int i = 0; i < primaryKey.Length; i++)
                    {
                        if (selection.Columns.Contains(primaryKey[i]))
                        {
                            newRowKey.Add(rowKey[i]);
                        }
                    }

                    for (int i = 0; i < columns.Length; i++)
                    {
                        if (selection.Columns.Contains(columns[i]))
                        {
                            newRowColumns.Add(rowColumns[i]);
                        }
                    }

                    yield return new KeyValuePair<string, string>(KeyValue.Concatenate(newRowKey), KeyValue.Concatenate(newRowColumns));
                }
            }
        }

        public KeyValuePair<string, string> GetMetadata()
        {
            if (selection.Columns.Contains("*"))
            {
                return metadata;
            }
            else
            {
                var primaryKey = KeyValue.Split(metadata.Key).ToArray();
                var columns = KeyValue.Split(metadata.Value).ToArray();

                var newRowKey = new List<string>();
                var newRowColumns = new List<string>();

                for (int i = 0; i < primaryKey.Length; i++)
                {
                    if (selection.Columns.Contains(primaryKey[i]))
                    {
                        newRowKey.Add(primaryKey[i]);
                    }
                }

                for (int i = 0; i < columns.Length; i++)
                {
                    if (selection.Columns.Contains(columns[i]))
                    {
                        newRowColumns.Add(columns[i]);
                    }
                }

                return new KeyValuePair<string, string>(KeyValue.Concatenate(newRowKey), KeyValue.Concatenate(newRowColumns));
            }
        }
    }
}
