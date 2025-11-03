using System;
using System.Windows.Forms;

namespace Programm6Assignment2
{
    public partial class ResultForm : Form
    {
        private readonly string _username;
        private readonly int _score;
        private readonly int _max;

        public ResultForm(string username, int score, int max)
        {
            _username = username;
            _score = score;
            _max = max;
            InitializeComponent();

            lblUser.Text = $"User: {_username}";
            lblScore.Text = $"Score: {_score} / {_max}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var login = new Form1();
            login.Show();
            this.Close();
        }
    }
}