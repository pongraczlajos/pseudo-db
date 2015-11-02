using PseudoDb.Interfaces.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Query
{
    public interface IQuery
    {
        void Insert(Database database, Table table, ICollection<string> keyMembers, ICollection<string> values);
    }
}
