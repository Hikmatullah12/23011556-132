using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Programm6Assignment2
{
    partial class ResultForm
    {
        private IContainer components = null;
        private Label lblUser;
        private Label lblScore;
        private Button btnLogout;
        private Button btnExit;

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
            this.lblUser = new Label();
            this.lblScore = new Label();
            this.btnLogout = new Button();
            this.btnExit = new Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new Point(22, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new Size(38, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new Point(22, 54);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new Size(41, 15);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new Point(22, 95);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(110, 28);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout (Login)";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new Point(140, 95);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(110, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(274, 145);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}