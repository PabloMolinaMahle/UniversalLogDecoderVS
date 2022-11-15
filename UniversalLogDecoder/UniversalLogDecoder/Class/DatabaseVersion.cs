using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbcUtilities;

namespace DatabaseManagerTest.Class
{
    public class DatabaseVersion
    {
        public string databaseVersionName;

        public Database originalDBC;

        public Dictionary<string, Database> customDBCDict;

        public DatabaseVersion(string databaseVersionName, Database originalDBC)
        {
            this.databaseVersionName = databaseVersionName;
            this.originalDBC = originalDBC;
            customDBCDict = new Dictionary<string, Database>();
        }
    }
}
