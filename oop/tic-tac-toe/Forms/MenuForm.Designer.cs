using System.ComponentModel;

namespace tic_tac_toe.Forms
{
    partial class MenuForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.playGameButton = new System.Windows.Forms.Button();
            this.informationButton = new System.Windows.Forms.Button();
            this.historyGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.ExitButton.Location = new System.Drawing.Point(280, 326);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(216, 49);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Вийти з акаунту";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // playGameButton
            // 
            this.playGameButton.BackColor = System.Drawing.Color.Lime;
            this.playGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playGameButton.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.playGameButton.Location = new System.Drawing.Point(280, 81);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(216, 47);
            this.playGameButton.TabIndex = 20;
            this.playGameButton.Text = "Зіграти гру";
            this.playGameButton.UseVisualStyleBackColor = false;
            this.playGameButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // informationButton
            // 
            this.informationButton.BackColor = System.Drawing.Color.Lime;
            this.informationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationButton.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.informationButton.Location = new System.Drawing.Point(280, 249);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(216, 47);
            this.informationButton.TabIndex = 18;
            this.informationButton.Text = "Інформація";
            this.informationButton.UseVisualStyleBackColor = false;
            this.informationButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // historyGameButton
            // 
            this.historyGameButton.BackColor = System.Drawing.Color.Lime;
            this.historyGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyGameButton.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.historyGameButton.Location = new System.Drawing.Point(280, 165);
            this.historyGameButton.Name = "historyGameButton";
            this.historyGameButton.Size = new System.Drawing.Size(216, 47);
            this.historyGameButton.TabIndex = 21;
            this.historyGameButton.Text = "Історія ігор";
            this.historyGameButton.UseVisualStyleBackColor = false;
            this.historyGameButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button4_MouseClick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyGameButton);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.informationButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tic-tac-toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button historyGameButton;

        private System.Windows.Forms.Button informationButton;

        private System.Windows.Forms.Button ExitButton;

        #endregion
    }
}