using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces
{
    public class KeyValue
    {
        public static string Concatenate(IEnumerable<string> values)
        {
            return string.Join("#", values);
        }

        public static IEnumerable<string> Split(string value)
        {
            return value.Split('#');
        }

        public static string GetDatabaseFileName(string databaseName)
        {
            return string.Format("{0}.stsdb4", databaseName);
        }
    }
}
