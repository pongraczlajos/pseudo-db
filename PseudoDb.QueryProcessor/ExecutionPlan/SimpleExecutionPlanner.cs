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
                    var indexScanFilter = TryGetFilterWithIndex(filters);
                    var firstFilter = indexScanFilter.Key;
                    var table = database.GetTable(firstFilter.Table);
                    IExecutionPlanOperation predecessor = null;

                    if (indexScanFilter.Value != null)
                    {
                        var readOperation = new NonUniqueScanOperation(table, indexScanFilter.Value, firstFilter, repository,
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

        private KeyValuePair<Filter, IConcreteIndex> TryGetFilterWithIndex(ICollection<Filter> sameTableFilters)
        {
            var indexFactory = new IndexFactory(KeyValue.GetDatabaseFileName(database.Name), repository);
            var table = database.Tables.Single(t => t.Name == sameTableFilters.First().Table);

            foreach (var filter in sameTableFilters)
            {
                var associations = database.Associations.Where(a => a.Child == table.Name && a.ColumnMappings.Values.Contains(filter.Column) && a.ColumnMappings.Count == 1);

                if (associations.Any())
                {
                    var association = associations.First();
                    var parentTable = database.Tables.Single(t => t.Name == association.Parent);
                    var indexMeta = parentTable.Indexes.Where(i => i.Name.Equals(association.Name)).Single();
                    var index = indexFactory.GetIndex(indexMeta);

                    return new KeyValuePair<Filter, IConcreteIndex>(filter, index);
                }
            }

            return new KeyValuePair<Filter, IConcreteIndex>(filters.First(), null);
        }
    }
}
