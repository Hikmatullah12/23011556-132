using System.ComponentModel;
using System.Windows.Forms;

namespace Programm6Assignment2
{
    partial class QuizForm
    {
        private IContainer components = null;
        private Label lblWelcome;
        private GroupBox groupBox1;
        private RadioButton rbQ1A;
        private RadioButton rbQ1B;
        private RadioButton rbQ1C;
        private RadioButton rbQ1D;

        private GroupBox groupBox2;
        private RadioButton rbQ2A;
        private RadioButton rbQ2B;
        private RadioButton rbQ2C;
        private RadioButton rbQ2D;

        private GroupBox groupBox3;
        private RadioButton rbQ3A;
        private RadioButton rbQ3B;
        private RadioButton rbQ3C;
        private RadioButton rbQ3D;

        private GroupBox groupBox4;
        private RadioButton rbQ4A;
        private RadioButton rbQ4B;
        private RadioButton rbQ4C;
        private RadioButton rbQ4D;

        private GroupBox groupBox5;
        private RadioButton rbQ5A;
        private RadioButton rbQ5B;
        private RadioButton rbQ5C;
        private RadioButton rbQ5D;

        private Button btnSubmit;

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
            this.lblWelcome = new Label();
            this.groupBox1 = new GroupBox();
            this.rbQ1A = new RadioButton();
            this.rbQ1B = new RadioButton();
            this.rbQ1C = new RadioButton();
            this.rbQ1D = new RadioButton();

            this.groupBox2 = new GroupBox();
            this.rbQ2A = new RadioButton();
            this.rbQ2B = new RadioButton();
            this.rbQ2C = new RadioButton();
            this.rbQ2D = new RadioButton();

            this.groupBox3 = new GroupBox();
            this.rbQ3A = new RadioButton();
            this.rbQ3B = new RadioButton();
            this.rbQ3C = new RadioButton();
            this.rbQ3D = new RadioButton();

            this.groupBox4 = new GroupBox();
            this.rbQ4A = new RadioButton();
            this.rbQ4B = new RadioButton();
            this.rbQ4C = new RadioButton();
            this.rbQ4D = new RadioButton();

            this.groupBox5 = new GroupBox();
            this.rbQ5A = new RadioButton();
            this.rbQ5B = new RadioButton();
            this.rbQ5C = new RadioButton();
            this.rbQ5D = new RadioButton();

            this.btnSubmit = new Button();

            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(14, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(60, 15);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // groupBox1 (Question 1)
            // 
            this.groupBox1.Controls.Add(this.rbQ1A);
            this.groupBox1.Controls.Add(this.rbQ1B);
            this.groupBox1.Controls.Add(this.rbQ1C);
            this.groupBox1.Controls.Add(this.rbQ1D);
            this.groupBox1.Location = new System.Drawing.Point(14, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1) Which option is correct for Q1?";
            // 
            // Q1 radio buttons
            // 
            this.rbQ1A.AutoSize = true;
            this.rbQ1A.Location = new System.Drawing.Point(6, 22);
            this.rbQ1A.Name = "rbQ1A";
            this.rbQ1A.Size = new System.Drawing.Size(36, 19);
            this.rbQ1A.TabIndex = 0;
            this.rbQ1A.Text = "A";
            this.rbQ1A.UseVisualStyleBackColor = true;

            this.rbQ1B.AutoSize = true;
            this.rbQ1B.Location = new System.Drawing.Point(90, 22);
            this.rbQ1B.Name = "rbQ1B";
            this.rbQ1B.Size = new System.Drawing.Size(36, 19);
            this.rbQ1B.TabIndex = 1;
            this.rbQ1B.Text = "B";
            this.rbQ1B.UseVisualStyleBackColor = true;

            this.rbQ1C.AutoSize = true;
            this.rbQ1C.Location = new System.Drawing.Point(180, 22);
            this.rbQ1C.Name = "rbQ1C";
            this.rbQ1C.Size = new System.Drawing.Size(36, 19);
            this.rbQ1C.TabIndex = 2;
            this.rbQ1C.Text = "C";
            this.rbQ1C.UseVisualStyleBackColor = true;

            this.rbQ1D.AutoSize = true;
            this.rbQ1D.Location = new System.Drawing.Point(270, 22);
            this.rbQ1D.Name = "rbQ1D";
            this.rbQ1D.Size = new System.Drawing.Size(37, 19);
            this.rbQ1D.TabIndex = 3;
            this.rbQ1D.Text = "D";
            this.rbQ1D.UseVisualStyleBackColor = true;

            // 
            // groupBox2 (Question 2)
            // 
            this.groupBox2.Controls.Add(this.rbQ2A);
            this.groupBox2.Controls.Add(this.rbQ2B);
            this.groupBox2.Controls.Add(this.rbQ2C);
            this.groupBox2.Controls.Add(this.rbQ2D);
            this.groupBox2.Location = new System.Drawing.Point(14, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 60);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2) Which option is correct for Q2?";
            // Q2 radio buttons
            this.rbQ2A.AutoSize = true;
            this.rbQ2A.Location = new System.Drawing.Point(6, 22);
            this.rbQ2A.Name = "rbQ2A";
            this.rbQ2A.Size = new System.Drawing.Size(36, 19);
            this.rbQ2A.TabIndex = 0;
            this.rbQ2A.Text = "A";
            this.rbQ2A.UseVisualStyleBackColor = true;

            this.rbQ2B.AutoSize = true;
            this.rbQ2B.Location = new System.Drawing.Point(90, 22);
            this.rbQ2B.Name = "rbQ2B";
            this.rbQ2B.Size = new System.Drawing.Size(36, 19);
            this.rbQ2B.TabIndex = 1;
            this.rbQ2B.Text = "B";
            this.rbQ2B.UseVisualStyleBackColor = true;

            this.rbQ2C.AutoSize = true;
            this.rbQ2C.Location = new System.Drawing.Point(180, 22);
            this.rbQ2C.Name = "rbQ2C";
            this.rbQ2C.Size = new System.Drawing.Size(36, 19);
            this.rbQ2C.TabIndex = 2;
            this.rbQ2C.Text = "C";
            this.rbQ2C.UseVisualStyleBackColor = true;

            this.rbQ2D.AutoSize = true;
            this.rbQ2D.Location = new System.Drawing.Point(270, 22);
            this.rbQ2D.Name = "rbQ2D";
            this.rbQ2D.Size = new System.Drawing.Size(37, 19);
            this.rbQ2D.TabIndex = 3;
            this.rbQ2D.Text = "D";
            this.rbQ2D.UseVisualStyleBackColor = true;

            // 
            // groupBox3 (Question 3)
            // 
            this.groupBox3.Controls.Add(this.rbQ3A);
            this.groupBox3.Controls.Add(this.rbQ3B);
            this.groupBox3.Controls.Add(this.rbQ3C);
            this.groupBox3.Controls.Add(this.rbQ3D);
            this.groupBox3.Location = new System.Drawing.Point(14, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 60);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3) Which option is correct for Q3?";
            // Q3 radio buttons
            this.rbQ3A.AutoSize = true;
            this.rbQ3A.Location = new System.Drawing.Point(6, 22);
            this.rbQ3A.Name = "rbQ3A";
            this.rbQ3A.Size = new System.Drawing.Size(36, 19);
            this.rbQ3A.TabIndex = 0;
            this.rbQ3A.Text = "A";
            this.rbQ3A.UseVisualStyleBackColor = true;

            this.rbQ3B.AutoSize = true;
            this.rbQ3B.Location = new System.Drawing.Point(90, 22);
            this.rbQ3B.Name = "rbQ3B";
            this.rbQ3B.Size = new System.Drawing.Size(36, 19);
            this.rbQ3B.TabIndex = 1;
            this.rbQ3B.Text = "B";
            this.rbQ3B.UseVisualStyleBackColor = true;

            this.rbQ3C.AutoSize = true;
            this.rbQ3C.Location = new System.Drawing.Point(180, 22);
            this.rbQ3C.Name = "rbQ3C";
            this.rbQ3C.Size = new System.Drawing.Size(36, 19);
            this.rbQ3C.TabIndex = 2;
            this.rbQ3C.Text = "C";
            this.rbQ3C.UseVisualStyleBackColor = true;

            this.rbQ3D.AutoSize = true;
            this.rbQ3D.Location = new System.Drawing.Point(270, 22);
            this.rbQ3D.Name = "rbQ3D";
            this.rbQ3D.Size = new System.Drawing.Size(37, 19);
            this.rbQ3D.TabIndex = 3;
            this.rbQ3D.Text = "D";
            this.rbQ3D.UseVisualStyleBackColor = true;

            // 
            // groupBox4 (Question 4)
            // 
            this.groupBox4.Controls.Add(this.rbQ4A);
            this.groupBox4.Controls.Add(this.rbQ4B);
            this.groupBox4.Controls.Add(this.rbQ4C);
            this.groupBox4.Controls.Add(this.rbQ4D);
            this.groupBox4.Location = new System.Drawing.Point(14, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(500, 60);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4) Which option is correct for Q4?";
            // Q4 radio buttons
            this.rbQ4A.AutoSize = true;
            this.rbQ4A.Location = new System.Drawing.Point(6, 22);
            this.rbQ4A.Name = "rbQ4A";
            this.rbQ4A.Size = new System.Drawing.Size(36, 19);
            this.rbQ4A.TabIndex = 0;
            this.rbQ4A.Text = "A";
            this.rbQ4A.UseVisualStyleBackColor = true;

            this.rbQ4B.AutoSize = true;
            this.rbQ4B.Location = new System.Drawing.Point(90, 22);
            this.rbQ4B.Name = "rbQ4B";
            this.rbQ4B.Size = new System.Drawing.Size(36, 19);
            this.rbQ4B.TabIndex = 1;
            this.rbQ4B.Text = "B";
            this.rbQ4B.UseVisualStyleBackColor = true;

            this.rbQ4C.AutoSize = true;
            this.rbQ4C.Location = new System.Drawing.Point(180, 22);
            this.rbQ4C.Name = "rbQ4C";
            this.rbQ4C.Size = new System.Drawing.Size(36, 19);
            this.rbQ4C.TabIndex = 2;
            this.rbQ4C.Text = "C";
            this.rbQ4C.UseVisualStyleBackColor = true;

            this.rbQ4D.AutoSize = true;
            this.rbQ4D.Location = new System.Drawing.Point(270, 22);
            this.rbQ4D.Name = "rbQ4D";
            this.rbQ4D.Size = new System.Drawing.Size(37, 19);
            this.rbQ4D.TabIndex = 3;
            this.rbQ4D.Text = "D";
            this.rbQ4D.UseVisualStyleBackColor = true;

            // 
            // groupBox5 (Question 5)
            // 
            this.groupBox5.Controls.Add(this.rbQ5A);
            this.groupBox5.Controls.Add(this.rbQ5B);
            this.groupBox5.Controls.Add(this.rbQ5C);
            this.groupBox5.Controls.Add(this.rbQ5D);
            this.groupBox5.Location = new System.Drawing.Point(14, 320);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(500, 60);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "5) Which option is correct for Q5?";
            // Q5 radio buttons
            this.rbQ5A.AutoSize = true;
            this.rbQ5A.Location = new System.Drawing.Point(6, 22);
            this.rbQ5A.Name = "rbQ5A";
            this.rbQ5A.Size = new System.Drawing.Size(36, 19);
            this.rbQ5A.TabIndex = 0;
            this.rbQ5A.Text = "A";
            this.rbQ5A.UseVisualStyleBackColor = true;

            this.rbQ5B.AutoSize = true;
            this.rbQ5B.Location = new System.Drawing.Point(90, 22);
            this.rbQ5B.Name = "rbQ5B";
            this.rbQ5B.Size = new System.Drawing.Size(36, 19);
            this.rbQ5B.TabIndex = 1;
            this.rbQ5B.Text = "B";
            this.rbQ5B.UseVisualStyleBackColor = true;

            this.rbQ5C.AutoSize = true;
            this.rbQ5C.Location = new System.Drawing.Point(180, 22);
            this.rbQ5C.Name = "rbQ5C";
            this.rbQ5C.Size = new System.Drawing.Size(36, 19);
            this.rbQ5C.TabIndex = 2;
            this.rbQ5C.Text = "C";
            this.rbQ5C.UseVisualStyleBackColor = true;

            this.rbQ5D.AutoSize = true;
            this.rbQ5D.Location = new System.Drawing.Point(270, 22);
            this.rbQ5D.Name = "rbQ5D";
            this.rbQ5D.Size = new System.Drawing.Size(37, 19);
            this.rbQ5D.TabIndex = 3;
            this.rbQ5D.Text = "D";
            this.rbQ5D.UseVisualStyleBackColor = true;

            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(424, 392);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 30);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // 
            // QuizForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 441);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}