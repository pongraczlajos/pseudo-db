using log4net;
using PseudoDb.Interfaces;
using PseudoDb.Interfaces.Indexing;
using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Query;
using PseudoDb.Interfaces.Storage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PseudoDb.QueryProcessor.ExecutionPlan
{
    class IndexedScanOperation : IExecutionPlanOperation
    {
        public IExecutionPlanOperation Predecessor { get; set; }

        private IRepository repository;

        private IConcreteIndex index;

        private Filter filter;

        private Table table;

        private string databaseFile;

        private string tableName;

        private ILog log;

        public IndexedScanOperation(Table table, IConcreteIndex index, Filter filter,
            IRepository repository, string databaseFile, string tableName)
        {
            this.table = table;
            this.index = index;
            this.filter = filter;
            this.repository = repository;
            this.databaseFile = databaseFile;
            this.tableName = tableName;

            log4net.Config.XmlConfigurator.Configure();
            log = LogManager.GetLogger("ExecutionPlan");
        }

        public IEnumerable<KeyValuePair<string, string>> Execute()
        {
            log.Info(string.Format("Indexed scan operation for '{0}', filter: '{1}' {2} '{3}'.", tableName, filter.Column,
                OperatorConverter.ToComboString(filter.Operator).ToString(), filter.Value));
            throw new NotImplementedException();
        }

        public KeyValuePair<string, string> GetMetadata()
        {
            return new KeyValuePair<string, string>(KeyValue.Concatenate(table.PrimaryKey), KeyValue.Concatenate(table.Columns.Where(c => !table.PrimaryKey.Contains(c.Name)).Select(c => c.Name)));
        }
    }
}
