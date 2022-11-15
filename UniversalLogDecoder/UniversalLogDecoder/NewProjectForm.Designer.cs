namespace UniversalLogDecoder
{
    partial class NewProjectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_NewProjectName = new System.Windows.Forms.TextBox();
            this.btn_NewProject = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New project name";
            // 
            // txtBox_NewProjectName
            // 
            this.txtBox_NewProjectName.Location = new System.Drawing.Point(13, 30);
            this.txtBox_NewProjectName.Name = "txtBox_NewProjectName";
            this.txtBox_NewProjectName.Size = new System.Drawing.Size(213, 20);
            this.txtBox_NewProjectName.TabIndex = 1;
            // 
            // btn_NewProject
            // 
            this.btn_NewProject.Location = new System.Drawing.Point(16, 68);
            this.btn_NewProject.Name = "btn_NewProject";
            this.btn_NewProject.Size = new System.Drawing.Size(90, 23);
            this.btn_NewProject.TabIndex = 2;
            this.btn_NewProject.Text = "Create Project";
            this.btn_NewProject.UseVisualStyleBackColor = true;
            this.btn_NewProject.Click += new System.EventHandler(this.btn_NewProject_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(147, 68);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 111);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_NewProject);
            this.Controls.Add(this.txtBox_NewProjectName);
            this.Controls.Add(this.label1);
            this.Name = "NewProjectForm";
            this.Text = "New project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_NewProjectName;
        private System.Windows.Forms.Button btn_NewProject;
        private System.Windows.Forms.Button btn_Cancel;
    }
}