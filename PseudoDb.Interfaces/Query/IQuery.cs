using PseudoDb.Interfaces.Metadata;
using System.Collections.Generic;
using System.Data;

namespace PseudoDb.Interfaces.Query
{
    public interface IQuery
    {
        ReturnStatus Insert(Database database, Table table, ICollection<string> keyMembers, ICollection<string> values);

        ReturnStatus Delete(Database database, Table table, ICollection<Filter> filters);
        
        DataTable Select(Database database, ICollection<Selection> selections, ICollection<Join> joins, ICollection<Filter> filters);

        void DeleteTable(Database database, Table table);

        DataTable GetAll(Database database, Table table);
    }
}
