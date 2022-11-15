using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagerTest.Class
{
    public class DatabaseManager
    {
        public Dictionary<string, BikeProject> bikeProjectDict = new Dictionary<string, BikeProject>();

        public void CreateTestProject(string projectName)
        {
            // Check if there is a project with the same name
            if (!bikeProjectDict.ContainsKey(projectName))
            {
                BikeProject bikeProject = new BikeProject(projectName);

                bikeProjectDict.Add(projectName, bikeProject);
            }
            else
            {
                //TODO mensaje emergente de advertencia
                Console.WriteLine("Project name already used");
            }
            
        }

        public void AddProject()
        {
            // Create a new project
        }

        public void DeleteProject(BikeProject deleteProject)
        {

        }
    }
}
