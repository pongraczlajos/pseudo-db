using PseudoDb.Engine.Common;
using PseudoDb.Interfaces.Engine;
using PseudoDb.Interfaces.Metadata;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace PseudoDb.Engine
{
    public class DbEngine : IEngine
    {
        private static string Location = @"..\..\..\Databases";

        private List<Database> databases;

        public DbEngine()
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

        public List<Database> GetDatabases()
        {
            //databases = new List<Database>();
            var db1 = new Database();
            db1.Name = "Database1";
            {
                var t1 = new Table();
                t1.Name = "Table 1";
                var t2 = new Table();
                t2.Name = "Table 2";
                var t3 = new Table();
                t3.Name = "Table 3";
                db1.Tables.Add(t1);
                db1.Tables.Add(t2);
                db1.Tables.Add(t3);

            }
            databases.Add(db1);

            var db2 = new Database();
            db2.Name = "Database2";
            {
                var t1 = new Table();
                t1.Name = "Table 1";
                var t2 = new Table();
                t2.Name = "Table 2";
                var t3 = new Table();
                t3.Name = "Table 3";
                db2.Tables.Add(t1);
                db2.Tables.Add(t2);
                db2.Tables.Add(t3);
            }
            databases.Add(db2);

            var db3 = new Database();
            db3.Name = "Database3";
            {
                var t1 = new Table();
                t1.Name = "Table 1";
                var t2 = new Table();
                t2.Name = "Table 2";
                var t3 = new Table();
                t3.Name = "Table 3";
                db3.Tables.Add(t1);
                db3.Tables.Add(t2);
                db3.Tables.Add(t3);
            }
            databases.Add(db3);
            return databases;
        }
    }
}
