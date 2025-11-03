using System.Windows.Forms;

namespace program3
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblName;
        private Label lblAge;
        private Label lblClass;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtClass;
        private Button btnSave;
        private Button btnCancel;

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
            this.lblName = new Label();
            this.lblAge = new Label();
            this.lblClass = new Label();
            this.txtName = new TextBox();
            this.txtAge = new TextBox();
            this.txtClass = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            // Form
            this.Text = "Add Student";
            this.ClientSize = new System.Drawing.Size(360, 180);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            // lblName
            this.lblName.Text = "Name:";
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 20);

            // txtName
            this.txtName.Location = new System.Drawing.Point(100, 18);
            this.txtName.Width = 230;

            // lblAge
            this.lblAge.Text = "Age:";
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(20, 58);

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(100, 56);
            this.txtAge.Width = 80;

            // lblClass
            this.lblClass.Text = "Class:";
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(20, 96);

            // txtClass
            this.txtClass.Location = new System.Drawing.Point(100, 94);
            this.txtClass.Width = 230;

            // btnSave
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(100, 130);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(190, 130);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add controls
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
        }
    }
}