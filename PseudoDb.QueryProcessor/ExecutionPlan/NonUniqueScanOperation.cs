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
    class NonUniqueScanOperation : IExecutionPlanOperation
    {
        public IExecutionPlanOperation Predecessor { get; set; }

        private IRepository repository;

        private IConcreteIndex index;

        private Filter filter;

        private Table table;

        private string databaseFile;

        private string tableName;

        private ILog log;

        public NonUniqueScanOperation(Table table, IConcreteIndex index, Filter filter,
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

            switch (filter.Operator)
            {
                case Operator.Equal:
                    var keys = index.Get(filter.Value);

                    foreach (var key in keys)
                    {
                        yield return new KeyValuePair<string, string>(key, repository.Get(databaseFile, table.Name, key));
                    }
                    break;
                case Operator.NotEqual:
                    foreach (var row in GetNotEqual())
                    {
                        yield return row;
                    }
                    break;
                case Operator.Less:
                    foreach (var row in GetLess())
                    {
                        yield return row;
                    }
                    break;
                case Operator.LessOrEqual:
                    foreach (var row in GetLessOrEqual())
                    {
                        yield return row;
                    }
                    break;
                case Operator.Greater:
                    foreach (var row in GetGreater())
                    {
                        yield return row;
                    }
                    break;
                case Operator.GreaterOrEqual:
                    foreach (var row in GetGreaterOrEqual())
                    {
                        yield return row;
                    }
                    break;
            }
        }

        public KeyValuePair<string, string> GetMetadata()
        {
            return new KeyValuePair<string, string>(KeyValue.Concatenate(table.PrimaryKey), KeyValue.Concatenate(table.Columns.Where(c => !table.PrimaryKey.Contains(c.Name)).Select(c => c.Name)));
        }

        private IEnumerable<KeyValuePair<string, string>> GetNotEqual()
        {
            var groups = index.GetAll().ToList();
            var equalItem = groups.First(p => p.Key == filter.Value);
            groups.Remove(equalItem);

            foreach (var group in groups)
            {
                var groupKeys = group.Value.Split(new string[] { "###" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var key in groupKeys)
                {
                    yield return new KeyValuePair<string, string>(key, repository.Get(databaseFile, table.Name, key));
                }
            }
        }

        private IEnumerable<KeyValuePair<string, string>> GetLess()
        {
            var groups = index.GetAll().Where(p => p.Key.CompareTo(filter.Value) < 0).ToList();

            foreach (var group in groups)
            {
                var groupKeys = group.Value.Split(new string[] { "###" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var key in groupKeys)
                {
                    yield return new KeyValuePair<string, string>(key, repository.Get(databaseFile, table.Name, key));
                }
            }
        }

        private IEnumerable<KeyValuePair<string, string>> GetLessOrEqual()
        {
            var groups = index.GetAll().Where(p => p.Key.CompareTo(filter.Value) <= 0).ToList();

            foreach (var group in groups)
            {
                var groupKeys = group.Value.Split(new string[] { "###" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var key in groupKeys)
                {
                    yield return new KeyValuePair<string, string>(key, repository.Get(databaseFile, table.Name, key));
                }
            }
        }

        private IEnumerable<KeyValuePair<string, string>> GetGreater()
        {
            var groups = index.GetAll().Where(p => p.Key.CompareTo(filter.Value) > 0).ToList();

            foreach (var group in groups)
            {
                var groupKeys = group.Value.Split(new string[] { "###" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var key in groupKeys)
                {
                    yield return new KeyValuePair<string, string>(key, repository.Get(databaseFile, table.Name, key));
                }
            }
        }

        private IEnumerable<KeyValuePair<string, string>> GetGreaterOrEqual()
        {
            var groups = index.GetAll().Where(p => p.Key.CompareTo(filter.Value) >= 0).ToList();

            foreach (var group in groups)
            {
                var groupKeys = group.Value.Split(new string[] { "###" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var key in groupKeys)
                {
                    yield return new KeyValuePair<string, string>(key, repository.Get(databaseFile, table.Name, key));
                }
            }
        }
    }
}
