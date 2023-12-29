using System.ComponentModel;

namespace tic_tac_toe.Forms
{
    partial class PlayGameForm
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
            this.playBut = new System.Windows.Forms.Button();
            this.oponentListBox = new System.Windows.Forms.ListBox();
            this.oponentText = new System.Windows.Forms.Label();
            this.oponentLabel = new System.Windows.Forms.Label();
            this.ratingTrackBar = new System.Windows.Forms.TrackBar();
            this.ratingText = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.typeGameLabel = new System.Windows.Forms.Label();
            this.classicRadio = new System.Windows.Forms.RadioButton();
            this.trainingRadio = new System.Windows.Forms.RadioButton();
            this.personalRadio = new System.Windows.Forms.RadioButton();
            this.closeBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.realCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ratingTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // playBut
            // 
            this.playBut.BackColor = System.Drawing.Color.Lime;
            this.playBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBut.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBut.Location = new System.Drawing.Point(830, 186);
            this.playBut.Name = "playBut";
            this.playBut.Size = new System.Drawing.Size(280, 80);
            this.playBut.TabIndex = 43;
            this.playBut.Text = "Зіграти гру";
            this.playBut.UseVisualStyleBackColor = false;
            this.playBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playBut_MouseClick);
            // 
            // oponentListBox
            // 
            this.oponentListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(84)))), ((int)(((byte)(182)))));
            this.oponentListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oponentListBox.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.oponentListBox.ForeColor = System.Drawing.Color.Lime;
            this.oponentListBox.FormattingEnabled = true;
            this.oponentListBox.ItemHeight = 28;
            this.oponentListBox.Location = new System.Drawing.Point(439, 186);
            this.oponentListBox.Name = "oponentListBox";
            this.oponentListBox.Size = new System.Drawing.Size(272, 308);
            this.oponentListBox.TabIndex = 44;
            this.oponentListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oponentListBox_MouseClick);
            // 
            // oponentText
            // 
            this.oponentText.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.oponentText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.oponentText.Location = new System.Drawing.Point(439, 101);
            this.oponentText.Name = "oponentText";
            this.oponentText.Size = new System.Drawing.Size(272, 67);
            this.oponentText.TabIndex = 45;
            this.oponentText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // oponentLabel
            // 
            this.oponentLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 18F);
            this.oponentLabel.ForeColor = System.Drawing.Color.Lime;
            this.oponentLabel.Location = new System.Drawing.Point(452, 50);
            this.oponentLabel.Name = "oponentLabel";
            this.oponentLabel.Size = new System.Drawing.Size(272, 51);
            this.oponentLabel.TabIndex = 46;
            this.oponentLabel.Text = "Противник:";
            this.oponentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ratingTrackBar
            // 
            this.ratingTrackBar.LargeChange = 1;
            this.ratingTrackBar.Location = new System.Drawing.Point(44, 456);
            this.ratingTrackBar.Minimum = 5;
            this.ratingTrackBar.Name = "ratingTrackBar";
            this.ratingTrackBar.Size = new System.Drawing.Size(246, 56);
            this.ratingTrackBar.TabIndex = 47;
            this.ratingTrackBar.Value = 5;
            this.ratingTrackBar.ValueChanged += new System.EventHandler(this.ratingTrackBar_ValueChanged);
            // 
            // ratingText
            // 
            this.ratingText.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.ratingText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ratingText.Location = new System.Drawing.Point(195, 397);
            this.ratingText.Name = "ratingText";
            this.ratingText.Size = new System.Drawing.Size(69, 30);
            this.ratingText.TabIndex = 48;
            this.ratingText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ratingLabel
            // 
            this.ratingLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 18F);
            this.ratingLabel.ForeColor = System.Drawing.Color.Lime;
            this.ratingLabel.Location = new System.Drawing.Point(44, 390);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(145, 41);
            this.ratingLabel.TabIndex = 49;
            this.ratingLabel.Text = "Рейтинг:";
            // 
            // typeGameLabel
            // 
            this.typeGameLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeGameLabel.ForeColor = System.Drawing.Color.Lime;
            this.typeGameLabel.Location = new System.Drawing.Point(44, 159);
            this.typeGameLabel.Name = "typeGameLabel";
            this.typeGameLabel.Size = new System.Drawing.Size(233, 41);
            this.typeGameLabel.TabIndex = 50;
            this.typeGameLabel.Text = "Тип гри:";
            // 
            // classicRadio
            // 
            this.classicRadio.Checked = true;
            this.classicRadio.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.classicRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.classicRadio.Location = new System.Drawing.Point(44, 225);
            this.classicRadio.Name = "classicRadio";
            this.classicRadio.Size = new System.Drawing.Size(233, 34);
            this.classicRadio.TabIndex = 51;
            this.classicRadio.TabStop = true;
            this.classicRadio.Text = "Класична";
            this.classicRadio.UseVisualStyleBackColor = true;
            this.classicRadio.CheckedChanged += new System.EventHandler(this.classicRadio_CheckedChanged);
            // 
            // trainingRadio
            // 
            this.trainingRadio.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trainingRadio.Location = new System.Drawing.Point(44, 329);
            this.trainingRadio.Name = "trainingRadio";
            this.trainingRadio.Size = new System.Drawing.Size(233, 34);
            this.trainingRadio.TabIndex = 52;
            this.trainingRadio.Text = "Тренувальна";
            this.trainingRadio.UseVisualStyleBackColor = true;
            this.trainingRadio.CheckedChanged += new System.EventHandler(this.trainingRadio_CheckedChanged);
            // 
            // personalRadio
            // 
            this.personalRadio.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.personalRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.personalRadio.Location = new System.Drawing.Point(44, 279);
            this.personalRadio.Name = "personalRadio";
            this.personalRadio.Size = new System.Drawing.Size(233, 34);
            this.personalRadio.TabIndex = 53;
            this.personalRadio.Text = "Персональна";
            this.personalRadio.UseVisualStyleBackColor = true;
            this.personalRadio.CheckedChanged += new System.EventHandler(this.personalRadio_CheckedChanged);
            // 
            // closeBut
            // 
            this.closeBut.BackColor = System.Drawing.Color.Red;
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBut.Location = new System.Drawing.Point(834, 298);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(280, 80);
            this.closeBut.TabIndex = 54;
            this.closeBut.Text = "Відмінна";
            this.closeBut.UseVisualStyleBackColor = false;
            this.closeBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBut_MouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 41);
            this.label1.TabIndex = 55;
            this.label1.Text = "Імітація гри:";
            // 
            // realCheckBox
            // 
            this.realCheckBox.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F);
            this.realCheckBox.Location = new System.Drawing.Point(44, 99);
            this.realCheckBox.Name = "realCheckBox";
            this.realCheckBox.Size = new System.Drawing.Size(233, 35);
            this.realCheckBox.TabIndex = 57;
            this.realCheckBox.Text = "Реальна";
            this.realCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlayGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.realCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.personalRadio);
            this.Controls.Add(this.trainingRadio);
            this.Controls.Add(this.classicRadio);
            this.Controls.Add(this.typeGameLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.ratingText);
            this.Controls.Add(this.ratingTrackBar);
            this.Controls.Add(this.oponentLabel);
            this.Controls.Add(this.oponentText);
            this.Controls.Add(this.oponentListBox);
            this.Controls.Add(this.playBut);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "PlayGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayGameForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ratingTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button playBut;
        private System.Windows.Forms.ListBox oponentListBox;
        private System.Windows.Forms.Label oponentText;
        private System.Windows.Forms.Label oponentLabel;
        private System.Windows.Forms.TrackBar ratingTrackBar;
        private System.Windows.Forms.Label ratingText;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label typeGameLabel;
        private System.Windows.Forms.RadioButton classicRadio;
        private System.Windows.Forms.RadioButton trainingRadio;
        private System.Windows.Forms.RadioButton personalRadio;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox realCheckBox;

        #endregion
    }
}