using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagerTest.Class;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace UniversalLogDecoder
{
    public partial class MainForm : Form
    {
        public static Dictionary<string, BikeProject> bikeProjectDict = new Dictionary<string, BikeProject>();

        public MainForm()
        {
            // Load project data
            LoadProjectData();

            InitializeComponent();
      
        }

        #region Load/Save

        private void LoadProjectData()
        {
            string fileName = "BikeProjects.json";
            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                var options = new JsonSerializerOptions { IncludeFields = true };
                bikeProjectDict = JsonSerializer.Deserialize<Dictionary<string, BikeProject>>(jsonString, options);
            }
        }

        private void SaveProjectData()
        {
            string fileName = "BikeProjects.json";
            var options = new JsonSerializerOptions { IncludeFields = true };
            string jsonString = JsonSerializer.Serialize(bikeProjectDict, options);
            File.WriteAllText(fileName, jsonString);

        }

        #endregion


        #region Button methods

        private void btn_OpenDbcManager_Click(object sender, EventArgs e)
        {
            DatabaseManagerForm databaseManagerForm = new DatabaseManagerForm(this);
            databaseManagerForm.ShowDialog(); // Shows Form
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            SaveProjectData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Load data from file
            LoadProjectData();

            // load data on combo box
            foreach (KeyValuePair<string, BikeProject> project in bikeProjectDict)
            {
                comboBox1.Items.Add(project.Key);
            }
        }
    }
}
