using PseudoDb.Engine.Common;
using PseudoDb.Interfaces.Engine;
using PseudoDb.Interfaces.Metadata;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PseudoDb.Engine
{
    public class Engine : IEngine
    {
        private static string Location = @"..\..\..\Databases";

        private List<Database> databases;

        public Engine()
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

        public void AddDatabase(string databaseName)
        {
            Database database = new Database();
            database.Name = databaseName;

            databases.Add(database);
        }

        public Database GetDatabase(string databaseName)
        {
            return databases.Where(db => db.Name.Equals(databaseName)).FirstOrDefault();
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

        public void Execute(Database database)
        {
            XmlSerializer.Serialize<Database>(database, Location + string.Format(@"\{0}.xml", database.Name));
        }
    }
}
