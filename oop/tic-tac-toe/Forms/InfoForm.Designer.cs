using System.ComponentModel;

namespace tic_tac_toe.Forms
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.closeBut = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gamesLemgthLoseText = new System.Windows.Forms.Label();
            this.gamesLemgthWinText = new System.Windows.Forms.Label();
            this.gamesLemgthText = new System.Windows.Forms.Label();
            this.ratingText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.typeAccountText = new System.Windows.Forms.Label();
            this.gamesLemgthTieText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBut
            // 
            this.closeBut.BackColor = System.Drawing.Color.Lime;
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBut.Location = new System.Drawing.Point(726, 29);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(120, 40);
            this.closeBut.TabIndex = 36;
            this.closeBut.Text = "Назад";
            this.closeBut.UseVisualStyleBackColor = false;
            this.closeBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usernameText.Location = new System.Drawing.Point(48, 466);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(417, 38);
            this.usernameText.TabIndex = 33;
            this.usernameText.Text = "Псевдонім: ";
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastNameText.Location = new System.Drawing.Point(48, 365);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(417, 38);
            this.lastNameText.TabIndex = 32;
            this.lastNameText.Text = "Прізвище: ";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNameText.Location = new System.Drawing.Point(48, 324);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(417, 41);
            this.firstNameText.TabIndex = 31;
            this.firstNameText.Text = "Ім\'я: ";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(169, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(496, 51);
            this.label9.TabIndex = 41;
            this.label9.Text = "Інформація про гравця ";
            // 
            // gamesLemgthLoseText
            // 
            this.gamesLemgthLoseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamesLemgthLoseText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gamesLemgthLoseText.Location = new System.Drawing.Point(487, 425);
            this.gamesLemgthLoseText.Name = "gamesLemgthLoseText";
            this.gamesLemgthLoseText.Size = new System.Drawing.Size(359, 41);
            this.gamesLemgthLoseText.TabIndex = 45;
            this.gamesLemgthLoseText.Text = "Кількість поразок:  ";
            // 
            // gamesLemgthWinText
            // 
            this.gamesLemgthWinText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamesLemgthWinText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gamesLemgthWinText.Location = new System.Drawing.Point(487, 375);
            this.gamesLemgthWinText.Name = "gamesLemgthWinText";
            this.gamesLemgthWinText.Size = new System.Drawing.Size(359, 38);
            this.gamesLemgthWinText.TabIndex = 44;
            this.gamesLemgthWinText.Text = "Кількість перемог:  ";
            // 
            // gamesLemgthText
            // 
            this.gamesLemgthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamesLemgthText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gamesLemgthText.Location = new System.Drawing.Point(487, 324);
            this.gamesLemgthText.Name = "gamesLemgthText";
            this.gamesLemgthText.Size = new System.Drawing.Size(359, 39);
            this.gamesLemgthText.TabIndex = 43;
            this.gamesLemgthText.Text = "Кількість ігор:  ";
            // 
            // ratingText
            // 
            this.ratingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ratingText.Location = new System.Drawing.Point(487, 285);
            this.ratingText.Name = "ratingText";
            this.ratingText.Size = new System.Drawing.Size(359, 39);
            this.ratingText.TabIndex = 42;
            this.ratingText.Text = "Рейтинг: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(609, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(471, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 433);
            this.label12.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(860, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 433);
            this.label13.TabIndex = 55;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(12, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 433);
            this.label18.TabIndex = 56;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(12, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(858, 11);
            this.label19.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(12, 528);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(858, 11);
            this.label20.TabIndex = 58;
            // 
            // typeAccountText
            // 
            this.typeAccountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeAccountText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.typeAccountText.Location = new System.Drawing.Point(48, 413);
            this.typeAccountText.Name = "typeAccountText";
            this.typeAccountText.Size = new System.Drawing.Size(417, 41);
            this.typeAccountText.TabIndex = 60;
            this.typeAccountText.Text = "Тип акаунту: ";
            // 
            // gamesLemgthTieText
            // 
            this.gamesLemgthTieText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamesLemgthTieText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gamesLemgthTieText.Location = new System.Drawing.Point(487, 475);
            this.gamesLemgthTieText.Name = "gamesLemgthTieText";
            this.gamesLemgthTieText.Size = new System.Drawing.Size(359, 41);
            this.gamesLemgthTieText.TabIndex = 61;
            this.gamesLemgthTieText.Text = "Кількість нічиїх:   ";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.gamesLemgthTieText);
            this.Controls.Add(this.typeAccountText);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gamesLemgthLoseText);
            this.Controls.Add(this.gamesLemgthWinText);
            this.Controls.Add(this.gamesLemgthText);
            this.Controls.Add(this.ratingText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label gamesLemgthTieText;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label typeAccountText;

        private System.Windows.Forms.Label gamesLemgthLoseText;
        private System.Windows.Forms.Label gamesLemgthWinText;
        private System.Windows.Forms.Label gamesLemgthText;
        private System.Windows.Forms.Label ratingText;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label firstNameText;

        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Label lastNameText;

        #endregion
    }
}