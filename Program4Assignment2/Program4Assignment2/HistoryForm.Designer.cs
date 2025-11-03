using System.Windows.Forms;

namespace Program4Assignment2
{
    partial class HistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxHistory;
        private Button closeButton;
        private Button clearButton;

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
            this.listBoxHistory = new ListBox();
            this.closeButton = new Button();
            this.clearButton = new Button();

            // listBoxHistory
            this.listBoxHistory.Location = new System.Drawing.Point(12, 12);
            this.listBoxHistory.Size = new System.Drawing.Size(360, 200);

            // clearButton
            this.clearButton.Text = "Clear";
            this.clearButton.Location = new System.Drawing.Point(12, 225);
            this.clearButton.Size = new System.Drawing.Size(80, 30);
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);

            // closeButton
            this.closeButton.Text = "Close";
            this.closeButton.Location = new System.Drawing.Point(292, 225);
            this.closeButton.Size = new System.Drawing.Size(80, 30);
            this.closeButton.Click += (s, e) => this.Close();

            // form
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.closeButton);
            this.Text = "History";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HistoryForm_Load);
        }
    }
}