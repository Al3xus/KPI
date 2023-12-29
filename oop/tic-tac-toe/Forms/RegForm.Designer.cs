using System.ComponentModel;

namespace tic_tac_toe.Forms
{
    partial class RegForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.signUpBut = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.closeBut = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassicAcc = new System.Windows.Forms.RadioButton();
            this.PremiumAcc = new System.Windows.Forms.RadioButton();
            this.changeTypeAccLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.firstNameTextBox.Location = new System.Drawing.Point(258, 161);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(225, 35);
            this.firstNameTextBox.TabIndex = 14;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.lastNameTextBox.Location = new System.Drawing.Point(258, 245);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(225, 35);
            this.lastNameTextBox.TabIndex = 15;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.userNameTextBox.Location = new System.Drawing.Point(258, 469);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(235, 35);
            this.userNameTextBox.TabIndex = 16;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNameLabel.Location = new System.Drawing.Point(258, 122);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(225, 23);
            this.firstNameLabel.TabIndex = 17;
            this.firstNameLabel.Text = "Введіть ім\'я:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastNameLabel.Location = new System.Drawing.Point(258, 209);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(225, 23);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Введіть прізвище:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userNameLabel.Location = new System.Drawing.Point(258, 428);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(235, 38);
            this.userNameLabel.TabIndex = 19;
            this.userNameLabel.Text = "Введіть псевдонім:";
            // 
            // signUpBut
            // 
            this.signUpBut.BackColor = System.Drawing.Color.Lime;
            this.signUpBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBut.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.signUpBut.Location = new System.Drawing.Point(258, 677);
            this.signUpBut.Name = "signUpBut";
            this.signUpBut.Size = new System.Drawing.Size(235, 47);
            this.signUpBut.TabIndex = 20;
            this.signUpBut.Text = "Зареєструватися";
            this.signUpBut.UseVisualStyleBackColor = false;
            this.signUpBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button5_MouseClick);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.passwordTextBox.Location = new System.Drawing.Point(258, 564);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(235, 35);
            this.passwordTextBox.TabIndex = 21;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordLabel.Location = new System.Drawing.Point(258, 523);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(235, 23);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "Введіть пароль:";
            // 
            // closeBut
            // 
            this.closeBut.BackColor = System.Drawing.Color.Lime;
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.closeBut.Location = new System.Drawing.Point(622, 28);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(120, 40);
            this.closeBut.TabIndex = 23;
            this.closeBut.Text = "Назад";
            this.closeBut.UseVisualStyleBackColor = false;
            this.closeBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(534, 572);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 22);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Видимий пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseCaptureChanged += new System.EventHandler(this.checkBox1_MouseCaptureChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(95, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(511, 44);
            this.label5.TabIndex = 27;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassicAcc
            // 
            this.ClassicAcc.Checked = true;
            this.ClassicAcc.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassicAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClassicAcc.Location = new System.Drawing.Point(258, 353);
            this.ClassicAcc.Name = "ClassicAcc";
            this.ClassicAcc.Size = new System.Drawing.Size(132, 24);
            this.ClassicAcc.TabIndex = 28;
            this.ClassicAcc.TabStop = true;
            this.ClassicAcc.Text = "Класичний";
            this.ClassicAcc.UseVisualStyleBackColor = true;
            // 
            // PremiumAcc
            // 
            this.PremiumAcc.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PremiumAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PremiumAcc.Location = new System.Drawing.Point(258, 383);
            this.PremiumAcc.Name = "PremiumAcc";
            this.PremiumAcc.Size = new System.Drawing.Size(132, 24);
            this.PremiumAcc.TabIndex = 29;
            this.PremiumAcc.Text = "Преміум";
            this.PremiumAcc.UseVisualStyleBackColor = true;
            // 
            // changeTypeAccLabel
            // 
            this.changeTypeAccLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.changeTypeAccLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changeTypeAccLabel.Location = new System.Drawing.Point(258, 308);
            this.changeTypeAccLabel.Name = "changeTypeAccLabel";
            this.changeTypeAccLabel.Size = new System.Drawing.Size(235, 31);
            this.changeTypeAccLabel.TabIndex = 30;
            this.changeTypeAccLabel.Text = "Виберіть тип акаунту:";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.changeTypeAccLabel);
            this.Controls.Add(this.PremiumAcc);
            this.Controls.Add(this.ClassicAcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.signUpBut);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tic-tac-toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label changeTypeAccLabel;

        private System.Windows.Forms.RadioButton ClassicAcc;
        private System.Windows.Forms.RadioButton PremiumAcc;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button signUpBut;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button closeBut;

        #endregion
    }
}