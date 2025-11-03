using System;
using System.Windows.Forms;

namespace Program4Assignment2
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private bool TryGetOperands(out double a, out double b)
        {
            a = b = 0;
            if (!double.TryParse(textBoxA.Text.Trim(), out a))
            {
                MessageBox.Show("Enter a valid number for the first value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxA.Focus();
                return false;
            }
            if (!double.TryParse(textBoxB.Text.Trim(), out b))
            {
                MessageBox.Show("Enter a valid number for the second value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxB.Focus();
                return false;
            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!TryGetOperands(out var a, out var b)) return;
            var result = a + b;
            resultTextBox.Text = result.ToString();
            CalculationHistory.Entries.Add($"{a} + {b} = {result}");
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (!TryGetOperands(out var a, out var b)) return;
            var result = a - b;
            resultTextBox.Text = result.ToString();
            CalculationHistory.Entries.Add($"{a} - {b} = {result}");
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            if (!TryGetOperands(out var a, out var b)) return;
            var result = a * b;
            resultTextBox.Text = result.ToString();
            CalculationHistory.Entries.Add($"{a} * {b} = {result}");
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (!TryGetOperands(out var a, out var b)) return;
            if (b == 0)
            {
                MessageBox.Show("Cannot divide by zero.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = a / b;
            resultTextBox.Text = result.ToString();
            CalculationHistory.Entries.Add($"{a} / {b} = {result}");
        }

        private void showHistoryButton_Click(object sender, EventArgs e)
        {
            using var hist = new HistoryForm();
            hist.ShowDialog();
        }
    }
}