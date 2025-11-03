using System;
using System.Linq;
using System.Windows.Forms;

namespace program3
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
            dgvStudents.AutoGenerateColumns = false;

            // Bind to static BindingList
            dgvStudents.DataSource = Student.Students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Select a student to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var student = dgvStudents.CurrentRow.DataBoundItem as Student;
            if (student == null) return;

            var res = MessageBox.Show($"Delete student '{student.Name}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Student.Remove(student);
            }
        }
    }
}