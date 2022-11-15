using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbcUtilities;

namespace DatabaseManagerTest.Class
{
    public class BikeProject
    {
        public string projectName;
        public List<DatabaseVersion> databaseVersionsList;

        //
        Database database = new Database();

        public BikeProject(string projectName)
        {
            this.projectName = projectName;
            databaseVersionsList = new List<DatabaseVersion>();
        }

        public void CreateDatabaseVersion()
        {
            // Load DBC
            database.ReadDatabase("C:\\Users\\M0188337\\Desktop\\M20 Visual Studio test\\M20Simplified.dbc");

            Console.WriteLine("\nLoaded database:");
            database.ShowDatabase();

            DatabaseVersion databaseVersion = new DatabaseVersion("M20_V2.6", database);

            Console.WriteLine("\nFinish program:");
        }

        public void AddDatabaseVersion(DatabaseVersion databaseVersion)
        {
            
        }

        public void DeleteDatabaseVersion(DatabaseVersion databaseVersion)
        {

        }


    }
}
