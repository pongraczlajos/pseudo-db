using PseudoDb.Engine.Common;
using PseudoDb.Interfaces.Metadata;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Engine
{
    class Metadata : IMetadata
    {
        private static string Location = @"..\..\..\Databases";

        private List<Database> databases;

        public Metadata()
        {
            databases = new List<Database>();

            if (!Directory.Exists(Location))
            {
                Directory.CreateDirectory(Location);
            }

            foreach (var filePath in Directory.GetFiles(Location))
            {
                databases.Add(XmlSerializer.Deserialize<Database>(filePath));
            }
        }

        public ICollection<Database> GetDatabases()
        {
            return databases;
        }

        public Database GetDatabase(string databaseName)
        {
            return databases.Where(db => db.Name.Equals(databaseName)).FirstOrDefault();
        }

        public void AddDatabase(string databaseName)
        {
            Database database = new Database();
            database.Name = databaseName;

            databases.Add(database);

            XmlSerializer.Serialize<Database>(database, Location + string.Format(@"\{0}.xml", database.Name));
        }

        public void UpdateDatabase(string databaseName)
        {
            Database database = databases.Where(db => db.Name.Equals(databaseName)).First();
            XmlSerializer.Serialize<Database>(database, Location + string.Format(@"\{0}.xml", database.Name));
        }

        public void RemoveDatabase(string databaseName)
        {
            Database database = databases.Where(db => db.Name.Equals(databaseName)).FirstOrDefault();

            if (database != null)
            {
                databases.Remove(database);
                File.Delete(Location + string.Format(@"\{0}.xml", databaseName));
            }
        }
    }
}
