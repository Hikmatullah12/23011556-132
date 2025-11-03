using System;
using System.Windows.Forms;

namespace Program4Assignment2
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            listBoxHistory.Items.Clear();
            foreach (var entry in CalculationHistory.Entries)
            {
                listBoxHistory.Items.Add(entry);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear history?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CalculationHistory.Entries.Clear();
                listBoxHistory.Items.Clear();
            }
        }
    }
}