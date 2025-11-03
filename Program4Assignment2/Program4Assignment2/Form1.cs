using System;
using System.Windows.Forms;

namespace Program4Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = usernameTextBox.Text.Trim();
            var pass = passwordTextBox.Text;

            if (user == "admin" && pass == "123")
            {
                var calc = new CalculatorForm();
                // When calculator closes show login again
                calc.FormClosed += (s, args) => this.Show();
                this.Hide();
                calc.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Clear();
                usernameTextBox.Focus();
            }
        }
    }
}
