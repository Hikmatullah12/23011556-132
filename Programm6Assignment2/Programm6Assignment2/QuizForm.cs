using System;
using System.Windows.Forms;

namespace Programm6Assignment2
{
    public partial class QuizForm : Form
    {
        private readonly string _username;

        public QuizForm(string username)
        {
            _username = username;
            InitializeComponent();
            lblWelcome.Text = $"Welcome, {_username}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int score = 0;

            // Correct options (hard-coded):
            // Q1 -> rbQ1B, Q2 -> rbQ2C, Q3 -> rbQ3A, Q4 -> rbQ4D, Q5 -> rbQ5B

            if (rbQ1B.Checked) score++;
            if (rbQ2C.Checked) score++;
            if (rbQ3A.Checked) score++;
            if (rbQ4D.Checked) score++;
            if (rbQ5B.Checked) score++;

            var result = new ResultForm(_username, score, 5);
            result.Show();
            this.Close();
        }
    }
}