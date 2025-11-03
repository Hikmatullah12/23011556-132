using System.Windows.Forms;

namespace program3
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddStudent;
        private Button btnViewStudents;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddStudent = new Button();
            this.btnViewStudents = new Button();
            this.btnExit = new Button();

            // Form
            this.Text = "Dashboard";
            this.ClientSize = new System.Drawing.Size(320, 140);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            // btnAddStudent
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Location = new System.Drawing.Point(20, 20);
            this.btnAddStudent.Size = new System.Drawing.Size(260, 28);
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);

            // btnViewStudents
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.Location = new System.Drawing.Point(20, 56);
            this.btnViewStudents.Size = new System.Drawing.Size(260, 28);
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);

            // btnExit
            this.btnExit.Text = "Exit";
            this.btnExit.Location = new System.Drawing.Point(20, 92);
            this.btnExit.Size = new System.Drawing.Size(260, 28);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // Add
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.btnExit);
        }
    }
}