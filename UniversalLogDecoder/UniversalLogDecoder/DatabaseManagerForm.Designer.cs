namespace UniversalLogDecoder
{
    partial class DatabaseManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_NewProject = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.cmbBox_Project = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NewDBCVersion = new System.Windows.Forms.Button();
            this.btn_NewFilteredDbc = new System.Windows.Forms.Button();
            this.treeView_ProjectDatabases = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btn_NewProject
            // 
            this.btn_NewProject.Location = new System.Drawing.Point(180, 29);
            this.btn_NewProject.Name = "btn_NewProject";
            this.btn_NewProject.Size = new System.Drawing.Size(75, 23);
            this.btn_NewProject.TabIndex = 13;
            this.btn_NewProject.Text = "New Project";
            this.btn_NewProject.UseVisualStyleBackColor = true;
            this.btn_NewProject.Click += new System.EventHandler(this.btn_NewProject_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(197, 519);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(15, 519);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 23);
            this.btn_Select.TabIndex = 11;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            // 
            // cmbBox_Project
            // 
            this.cmbBox_Project.FormattingEnabled = true;
            this.cmbBox_Project.Location = new System.Drawing.Point(15, 29);
            this.cmbBox_Project.Name = "cmbBox_Project";
            this.cmbBox_Project.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Project.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Databases";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Project";
            // 
            // btn_NewDBCVersion
            // 
            this.btn_NewDBCVersion.Location = new System.Drawing.Point(15, 87);
            this.btn_NewDBCVersion.Name = "btn_NewDBCVersion";
            this.btn_NewDBCVersion.Size = new System.Drawing.Size(105, 23);
            this.btn_NewDBCVersion.TabIndex = 14;
            this.btn_NewDBCVersion.Text = "New DBC version";
            this.btn_NewDBCVersion.UseVisualStyleBackColor = true;
            this.btn_NewDBCVersion.Click += new System.EventHandler(this.btn_NewDBCVersion_Click);
            // 
            // btn_NewFilteredDbc
            // 
            this.btn_NewFilteredDbc.Location = new System.Drawing.Point(167, 87);
            this.btn_NewFilteredDbc.Name = "btn_NewFilteredDbc";
            this.btn_NewFilteredDbc.Size = new System.Drawing.Size(105, 23);
            this.btn_NewFilteredDbc.TabIndex = 15;
            this.btn_NewFilteredDbc.Text = "New Filtered DBC";
            this.btn_NewFilteredDbc.UseVisualStyleBackColor = true;
            this.btn_NewFilteredDbc.Click += new System.EventHandler(this.btn_NewFilteredDbc_Click);
            // 
            // treeView_ProjectDatabases
            // 
            this.treeView_ProjectDatabases.Location = new System.Drawing.Point(15, 117);
            this.treeView_ProjectDatabases.Name = "treeView_ProjectDatabases";
            this.treeView_ProjectDatabases.Size = new System.Drawing.Size(257, 396);
            this.treeView_ProjectDatabases.TabIndex = 16;
            // 
            // DatabaseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 554);
            this.Controls.Add(this.treeView_ProjectDatabases);
            this.Controls.Add(this.btn_NewFilteredDbc);
            this.Controls.Add(this.btn_NewDBCVersion);
            this.Controls.Add(this.btn_NewProject);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.cmbBox_Project);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatabaseManagerForm";
            this.Text = "DatabaseManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewProject;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.ComboBox cmbBox_Project;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NewDBCVersion;
        private System.Windows.Forms.Button btn_NewFilteredDbc;
        private System.Windows.Forms.TreeView treeView_ProjectDatabases;
    }
}