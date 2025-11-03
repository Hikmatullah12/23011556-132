using System.Windows.Forms;

namespace Program4Assignment2
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Label labelA;
        private Label labelB;
        private Button addButton;
        private Button subButton;
        private Button mulButton;
        private Button divButton;
        private TextBox resultTextBox;
        private Label resultLabel;
        private Button showHistoryButton;

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
            this.textBoxA = new TextBox();
            this.textBoxB = new TextBox();
            this.labelA = new Label();
            this.labelB = new Label();
            this.addButton = new Button();
            this.subButton = new Button();
            this.mulButton = new Button();
            this.divButton = new Button();
            this.resultTextBox = new TextBox();
            this.resultLabel = new Label();
            this.showHistoryButton = new Button();

            // labels and textboxes
            this.labelA.Text = "First number:";
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(20, 20);

            this.textBoxA.Location = new System.Drawing.Point(120, 17);
            this.textBoxA.Size = new System.Drawing.Size(140, 23);

            this.labelB.Text = "Second number:";
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(20, 60);

            this.textBoxB.Location = new System.Drawing.Point(120, 57);
            this.textBoxB.Size = new System.Drawing.Size(140, 23);

            // buttons
            this.addButton.Text = "Add";
            this.addButton.Location = new System.Drawing.Point(20, 100);
            this.addButton.Size = new System.Drawing.Size(60, 30);
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

            this.subButton.Text = "Subtract";
            this.subButton.Location = new System.Drawing.Point(90, 100);
            this.subButton.Size = new System.Drawing.Size(70, 30);
            this.subButton.Click += new System.EventHandler(this.subButton_Click);

            this.mulButton.Text = "Multiply";
            this.mulButton.Location = new System.Drawing.Point(170, 100);
            this.mulButton.Size = new System.Drawing.Size(70, 30);
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);

            this.divButton.Text = "Divide";
            this.divButton.Location = new System.Drawing.Point(250, 100);
            this.divButton.Size = new System.Drawing.Size(60, 30);
            this.divButton.Click += new System.EventHandler(this.divButton_Click);

            // result
            this.resultLabel.Text = "Result:";
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(20, 150);

            this.resultTextBox.Location = new System.Drawing.Point(120, 147);
            this.resultTextBox.Size = new System.Drawing.Size(140, 23);
            this.resultTextBox.ReadOnly = true;

            // show history
            this.showHistoryButton.Text = "Show History";
            this.showHistoryButton.Location = new System.Drawing.Point(120, 190);
            this.showHistoryButton.Size = new System.Drawing.Size(120, 30);
            this.showHistoryButton.Click += new System.EventHandler(this.showHistoryButton_Click);

            // form
            this.ClientSize = new System.Drawing.Size(340, 240);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.showHistoryButton);
            this.Text = "Calculator";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}