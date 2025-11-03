using System;
using System.Windows.Forms;

namespace program3
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using var add = new AddStudentForm();
            add.ShowDialog();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            var view = new ViewStudentsForm();
            view.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}