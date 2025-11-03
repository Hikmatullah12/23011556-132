using System.Windows.Forms;

namespace program3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label lblUser;
        private Label lblPass;

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
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnExit = new Button();
            this.lblUser = new Label();
            this.lblPass = new Label();

            // Form
            this.Text = "Login";
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // lblUser
            this.lblUser.Text = "Username:";
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 25);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(100, 22);
            this.txtUsername.Width = 190;

            // lblPass
            this.lblPass.Text = "Password:";
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(20, 65);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(100, 62);
            this.txtPassword.Width = 190;
            this.txtPassword.UseSystemPasswordChar = true;

            // btnLogin
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(100, 105);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnExit
            this.btnExit.Text = "Exit";
            this.btnExit.Location = new System.Drawing.Point(190, 105);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // Add controls
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
        }

        #endregion
    }
}
