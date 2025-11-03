using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

    namespace Programm6Assignment2
{
    partial class Form1
    {
        private IContainer components = null;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

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

        private void InitializeComponent()
        {
            this.components = new Container();
            this.label1 = new Label();
            this.label2 = new Label();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new Point(115, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(180, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new Point(115, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(180, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new Point(115, 104);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(90, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            // 
            // Form1 (Login)
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(348, 160);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
