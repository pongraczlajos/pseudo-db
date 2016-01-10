﻿using PseudoDb.Interfaces;
using PseudoDb.Interfaces.Metadata;
using PseudoDb.Interfaces.Query;
using PseudoDb.Interfaces.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.QueryProcessor.ExecutionPlan
{
    class IndexedScanOperation : IExecutionPlanOperation
    {
        public IExecutionPlanOperation Predecessor { get; set; }

        private IRepository repository;

        private Table table;

        private string databaseFile;

        private string tableName;

        public IndexedScanOperation(Table table, IRepository repository, string databaseFile, string tableName)
        {
            this.table = table;
            this.repository = repository;
            this.databaseFile = databaseFile;
            this.tableName = tableName;
        }

        public IEnumerable<KeyValuePair<string, string>> Execute()
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<string, string> GetMetadata()
        {
            return new KeyValuePair<string, string>(KeyValue.Concatenate(table.PrimaryKey), KeyValue.Concatenate(table.Columns.Where(c => !table.PrimaryKey.Contains(c.Name)).Select(c => c.Name)));
        }
    }
}
