using System.ComponentModel;

namespace tic_tac_toe.Forms
{
    partial class LogOrRegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOrRegForm));
            this.logInBut = new System.Windows.Forms.Button();
            this.signUpBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logInBut
            // 
            this.logInBut.BackColor = System.Drawing.Color.Lime;
            this.logInBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBut.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.logInBut.Location = new System.Drawing.Point(459, 352);
            this.logInBut.Name = "logInBut";
            this.logInBut.Size = new System.Drawing.Size(235, 47);
            this.logInBut.TabIndex = 5;
            this.logInBut.Text = "Увійти";
            this.logInBut.UseVisualStyleBackColor = false;
            this.logInBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // signUpBut
            // 
            this.signUpBut.BackColor = System.Drawing.Color.Lime;
            this.signUpBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBut.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.signUpBut.Location = new System.Drawing.Point(99, 352);
            this.signUpBut.Name = "signUpBut";
            this.signUpBut.Size = new System.Drawing.Size(235, 47);
            this.signUpBut.TabIndex = 4;
            this.signUpBut.Text = "Зареєструватися";
            this.signUpBut.UseVisualStyleBackColor = false;
            this.signUpBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "Хрестики-нулики";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogOrRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logInBut);
            this.Controls.Add(this.signUpBut);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "LogOrRegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tic-tac-toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogOrRegForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button logInBut;
        private System.Windows.Forms.Button signUpBut;

        #endregion
    }
}