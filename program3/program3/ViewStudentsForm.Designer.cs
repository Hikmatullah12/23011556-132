using System.Windows.Forms;

namespace program3
{
    partial class ViewStudentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvStudents;
        private Button btnDelete;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colClass;

        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvStudents = new DataGridView();
            this.btnDelete = new Button();
            this.colId = new DataGridViewTextBoxColumn();
            this.colName = new DataGridViewTextBoxColumn();
            this.colAge = new DataGridViewTextBoxColumn();
            this.colClass = new DataGridViewTextBoxColumn();

            // Form
            this.Text = "View Students";
            this.ClientSize = new System.Drawing.Size(520, 320);
            this.StartPosition = FormStartPosition.CenterScreen;

            // dgvStudents
            this.dgvStudents.Location = new System.Drawing.Point(12, 12);
            this.dgvStudents.Size = new System.Drawing.Size(496, 260);
            this.dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;

            // Columns
            this.colId.HeaderText = "Id";
            this.colId.DataPropertyName = "Id";
            this.colId.Width = 50;

            this.colName.HeaderText = "Name";
            this.colName.DataPropertyName = "Name";
            this.colName.Width = 200;

            this.colAge.HeaderText = "Age";
            this.colAge.DataPropertyName = "Age";
            this.colAge.Width = 60;

            this.colClass.HeaderText = "Class";
            this.colClass.DataPropertyName = "ClassName";
            this.colClass.Width = 160;

            this.dgvStudents.Columns.AddRange(new DataGridViewColumn[] { this.colId, this.colName, this.colAge, this.colClass });

            // btnDelete
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Location = new System.Drawing.Point(12, 280);
            this.btnDelete.Size = new System.Drawing.Size(120, 28);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Add
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnDelete);
        }
    }
}