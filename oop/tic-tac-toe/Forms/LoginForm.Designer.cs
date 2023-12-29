using System.ComponentModel;

namespace tic_tac_toe.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.logInBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.closeBut = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(283, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Введіть пароль:";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.passwordBox.Location = new System.Drawing.Point(283, 235);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(238, 35);
            this.passwordBox.TabIndex = 26;
            // 
            // logInBut
            // 
            this.logInBut.BackColor = System.Drawing.Color.Lime;
            this.logInBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInBut.Location = new System.Drawing.Point(302, 304);
            this.logInBut.Name = "logInBut";
            this.logInBut.Size = new System.Drawing.Size(168, 47);
            this.logInBut.TabIndex = 25;
            this.logInBut.Text = "Увійти";
            this.logInBut.UseVisualStyleBackColor = false;
            this.logInBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button5_MouseClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(283, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 34);
            this.label3.TabIndex = 24;
            this.label3.Text = "Введіть псевдонім:";
            // 
            // userNameBox
            // 
            this.userNameBox.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.userNameBox.Location = new System.Drawing.Point(283, 154);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(238, 35);
            this.userNameBox.TabIndex = 23;
            // 
            // closeBut
            // 
            this.closeBut.BackColor = System.Drawing.Color.Lime;
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBut.Location = new System.Drawing.Point(652, 27);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(120, 40);
            this.closeBut.TabIndex = 28;
            this.closeBut.Text = "Назад";
            this.closeBut.UseVisualStyleBackColor = false;
            this.closeBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(540, 246);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 22);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Видимий пароль";
            this.checkBox1.MouseCaptureChanged += new System.EventHandler(this.checkBox1_MouseCaptureChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(38, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 119);
            this.label5.TabIndex = 30;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.logInBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameBox);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tic-tac-toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.Button closeBut;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button logInBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameBox;

        #endregion
    }
}