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

namespace UniversalLogDecoder
{
    public partial class DatabaseManagerForm : Form
    {
        private MainForm mainForm;

        public DatabaseManagerForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            LoadProjects();
        }

        public void LoadProjects()
        {
            // Clear list
            cmbBox_Project.Items.Clear();

            // Fill list
            foreach (KeyValuePair<string, BikeProject> project in MainForm.bikeProjectDict)
            {
                cmbBox_Project.Items.Add(project.Key);
            }
        }

        #region Button events

        private void btn_NewProject_Click(object sender, EventArgs e)
        {
            // Create new project
            NewProjectForm newProjectForm = new NewProjectForm(this);
            newProjectForm.ShowDialog(); // Shows Form
        }

        private void btn_NewDBCVersion_Click(object sender, EventArgs e)
        {
            // Create new DBC
        }

        private void btn_NewFilteredDbc_Click(object sender, EventArgs e)
        {
            // Create new Filtered DBC
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the Form instance.
        }

        #endregion
    }
}
