using PseudoDb.Interfaces;
using PseudoDb.Interfaces.Indexing;
using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Query;
using PseudoDb.Interfaces.Storage;
using System.Collections.Generic;
using System.Linq;

namespace PseudoDb.QueryProcessor.ExecutionPlan
{
    public class SimpleExecutionPlanner : IExecutionPlanner
    {
        private Database database;

        private IRepository repository;

        private ICollection<Selection> selections;

        private ICollection<Join> joins;

        private ICollection<Filter> filters;

        public SimpleExecutionPlanner(Database database, IRepository repository,
            ICollection<Selection> selections, ICollection<Join> joins, ICollection<Filter> filters)
        {
            this.database = database;
            this.repository = repository;
            this.selections = selections;
            this.joins = joins;
            this.filters = filters;
        }

        public IExecutionPlanOperation GetRootOperation()
        {
            // If no join then single table select/delete.
            if (!joins.Any())
            {
                if (filters.Any())
                {
                    // Try to get a filter which can use an index.
                    var indexScanFilter = TryGetFilterWithIndex();
                    var firstFilter = indexScanFilter.Key;
                    var table = database.GetTable(firstFilter.Table);
                    IExecutionPlanOperation predecessor = null;

                    if (indexScanFilter.Value != null)
                    {
                        var readOperation = new IndexedScanOperation(table, indexScanFilter.Value, firstFilter, repository,
                            KeyValue.GetDatabaseFileName(database.Name), table.Name);
                        predecessor = readOperation;
                    }
                    else
                    {
                        var readOperation = new FullScanOperation(table, repository, KeyValue.GetDatabaseFileName(database.Name),
                            table.Name);
                        predecessor = new FilterOperation(readOperation, firstFilter);
                    }

                    filters.Remove(firstFilter);

                    for (int i = 0; i < filters.Count; i++)
                    {
                        var operation = new FilterOperation(predecessor, filters.ElementAt(i));
                        predecessor = operation;
                    }

                    if (selections.Any())
                    {
                        predecessor = new SelectOperation(predecessor, selections.First());
                    }

                    return predecessor;
                }
                else
                {
                    var selection = selections.First();
                    var table = database.GetTable(selection.Table);
                    var fullScanOperation = new FullScanOperation(table, repository, KeyValue.GetDatabaseFileName(database.Name), table.Name);

                    return new SelectOperation(fullScanOperation, selection);
                }
            }
            else
            {
                // Handle selections with join operation.
                return null;
            }
        }

        private KeyValuePair<Filter, IConcreteIndex> TryGetFilterWithIndex()
        {
            var indexFactory = new IndexFactory(KeyValue.GetDatabaseFileName(database.Name), repository);

            foreach (var filter in filters)
            {
                var table = database.Tables.First(t => t.Name == filter.Table);
                if (table.PrimaryKey.Count == 1 && table.PrimaryKey.Contains(filter.Column))
                {
                    return new KeyValuePair<Filter, IConcreteIndex>(filter,
                        new PrimaryIndex(table, KeyValue.GetDatabaseFileName(database.Name), repository));
                }

                if (table.Indexes.Exists(i => i.Unique == true && i.IndexMembers.Count == 1 && i.IndexMembers.Contains(filter.Column)))
                {
                    var indexMeta = table.Indexes.First(i => i.Unique == true && i.IndexMembers.Count == 1 && i.IndexMembers.Contains(filter.Column));
                    return new KeyValuePair<Filter, IConcreteIndex>(filter, indexFactory.GetIndex(indexMeta));
                }


            }

            return new KeyValuePair<Filter, IConcreteIndex>(filters.First(), null);
        }
    }
}
