using System.Windows.Forms;

namespace Program4Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Button loginButton;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.usernameTextBox = new TextBox();
            this.passwordTextBox = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.loginButton = new Button();

            // 
            // label1
            // 
            this.label1.Text = "Username:";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(120, 27);
            this.usernameTextBox.Size = new System.Drawing.Size(180, 23);
            // 
            // label2
            // 
            this.label2.Text = "Password:";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(120, 67);
            this.passwordTextBox.Size = new System.Drawing.Size(180, 23);
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Text = "Login";
            this.loginButton.Location = new System.Drawing.Point(120, 110);
            this.loginButton.Size = new System.Drawing.Size(100, 30);
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginButton);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion
    }
}
