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
    public partial class NewProjectForm : Form
    {
        private DatabaseManagerForm databaseManagerForm;

        public NewProjectForm(DatabaseManagerForm databaseManagerForm)
        {
            InitializeComponent();

            this.databaseManagerForm = databaseManagerForm;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_NewProject_Click(object sender, EventArgs e)
        {
            string projectname = txtBox_NewProjectName.Text;
            
            // Check if name is valid
            if (projectname == null || projectname == "")
            {
                MessageBox.Show("Error: Project name not valid");
                return;
            }

            // Check if name is available
            if(MainForm.bikeProjectDict.ContainsKey(projectname))
            {
                // Error mesage
                MessageBox.Show("Error: Project name already in use");
                return;
            }

            // If the name is valid
            MainForm.bikeProjectDict.Add(txtBox_NewProjectName.Text, new BikeProject(txtBox_NewProjectName.Text));
            MessageBox.Show("New project created succesfully: " + projectname);

            //TODO evento que indica que se ha añadido un nuevo proyecto y recarga la lista del DatabaseManagerForm.
            databaseManagerForm.LoadProjects();

            // Close this form
            this.Close();
        }
    }
}
