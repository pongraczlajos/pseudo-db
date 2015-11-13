using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces.Indexing
{
    public interface IConcreteIndex
    {
        bool Exists(string key);

        IEnumerable<string> Get(string key);

        void Put(string key, string value);

        void Delete(string key);
    }
}
