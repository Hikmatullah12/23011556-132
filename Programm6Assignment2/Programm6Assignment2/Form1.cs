using System;
using System.Windows.Forms;

namespace Programm6Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUsername.Text.Trim();
            var pass = txtPassword.Text;

            if (user == "admin" && pass == "123")
            {
                var quiz = new QuizForm(user);
                quiz.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Use username = admin and password = 123", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
