namespace HfcsLab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
            this.Greyhound1 = new System.Windows.Forms.PictureBox();
            this.Greyhound2 = new System.Windows.Forms.PictureBox();
            this.Greyhound3 = new System.Windows.Forms.PictureBox();
            this.Greyhound4 = new System.Windows.Forms.PictureBox();
            this.bettingParlour = new System.Windows.Forms.GroupBox();
            this.raceButton = new System.Windows.Forms.Button();
            this.betButton = new System.Windows.Forms.Button();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.betValue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minBetLabel = new System.Windows.Forms.Label();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound4)).BeginInit();
            this.bettingParlour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betValue)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrackPictureBox
            // 
            this.raceTrackPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.raceTrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raceTrackPictureBox.Image")));
            this.raceTrackPictureBox.Location = new System.Drawing.Point(0, 0);
            this.raceTrackPictureBox.Name = "raceTrackPictureBox";
            this.raceTrackPictureBox.Size = new System.Drawing.Size(1303, 375);
            this.raceTrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrackPictureBox.TabIndex = 0;
            this.raceTrackPictureBox.TabStop = false;
            // 
            // Greyhound1
            // 
            this.Greyhound1.Image = ((System.Drawing.Image)(resources.GetObject("Greyhound1.Image")));
            this.Greyhound1.Location = new System.Drawing.Point(13, 13);
            this.Greyhound1.Name = "Greyhound1";
            this.Greyhound1.Size = new System.Drawing.Size(137, 50);
            this.Greyhound1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Greyhound1.TabIndex = 1;
            this.Greyhound1.TabStop = false;
            // 
            // Greyhound2
            // 
            this.Greyhound2.Image = ((System.Drawing.Image)(resources.GetObject("Greyhound2.Image")));
            this.Greyhound2.Location = new System.Drawing.Point(13, 98);
            this.Greyhound2.Name = "Greyhound2";
            this.Greyhound2.Size = new System.Drawing.Size(137, 50);
            this.Greyhound2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Greyhound2.TabIndex = 2;
            this.Greyhound2.TabStop = false;
            // 
            // Greyhound3
            // 
            this.Greyhound3.Image = ((System.Drawing.Image)(resources.GetObject("Greyhound3.Image")));
            this.Greyhound3.Location = new System.Drawing.Point(13, 198);
            this.Greyhound3.Name = "Greyhound3";
            this.Greyhound3.Size = new System.Drawing.Size(137, 50);
            this.Greyhound3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Greyhound3.TabIndex = 3;
            this.Greyhound3.TabStop = false;
            // 
            // Greyhound4
            // 
            this.Greyhound4.Image = ((System.Drawing.Image)(resources.GetObject("Greyhound4.Image")));
            this.Greyhound4.Location = new System.Drawing.Point(13, 298);
            this.Greyhound4.Name = "Greyhound4";
            this.Greyhound4.Size = new System.Drawing.Size(137, 50);
            this.Greyhound4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Greyhound4.TabIndex = 4;
            this.Greyhound4.TabStop = false;
            // 
            // bettingParlour
            // 
            this.bettingParlour.Controls.Add(this.raceButton);
            this.bettingParlour.Controls.Add(this.betButton);
            this.bettingParlour.Controls.Add(this.alRadioButton);
            this.bettingParlour.Controls.Add(this.bobRadioButton);
            this.bettingParlour.Controls.Add(this.joeRadioButton);
            this.bettingParlour.Controls.Add(this.dogNumber);
            this.bettingParlour.Controls.Add(this.betValue);
            this.bettingParlour.Controls.Add(this.label7);
            this.bettingParlour.Controls.Add(this.nameLabel);
            this.bettingParlour.Controls.Add(this.alBetLabel);
            this.bettingParlour.Controls.Add(this.bobBetLabel);
            this.bettingParlour.Controls.Add(this.joeBetLabel);
            this.bettingParlour.Controls.Add(this.label2);
            this.bettingParlour.Controls.Add(this.minBetLabel);
            this.bettingParlour.Location = new System.Drawing.Point(0, 382);
            this.bettingParlour.Name = "bettingParlour";
            this.bettingParlour.Size = new System.Drawing.Size(1291, 215);
            this.bettingParlour.TabIndex = 1;
            this.bettingParlour.TabStop = false;
            this.bettingParlour.Text = "Betting Parlor";
            // 
            // raceButton
            // 
            this.raceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceButton.Location = new System.Drawing.Point(901, 54);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(135, 81);
            this.raceButton.TabIndex = 7;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(166, 167);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 5;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(44, 116);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(118, 21);
            this.alRadioButton.TabIndex = 2;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(44, 84);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(131, 21);
            this.bobRadioButton.TabIndex = 1;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(44, 56);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(126, 21);
            this.joeRadioButton.TabIndex = 0;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(531, 171);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(120, 22);
            this.dogNumber.TabIndex = 4;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betValue
            // 
            this.betValue.Location = new System.Drawing.Point(247, 168);
            this.betValue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betValue.Name = "betValue";
            this.betValue.Size = new System.Drawing.Size(120, 22);
            this.betValue.TabIndex = 3;
            this.betValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "dollars on Dog number";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(107, 173);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "name";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(406, 121);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(332, 23);
            this.alBetLabel.TabIndex = 4;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(406, 89);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(332, 23);
            this.bobBetLabel.TabIndex = 3;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(406, 56);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(332, 23);
            this.joeBetLabel.TabIndex = 2;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bets";
            // 
            // minBetLabel
            // 
            this.minBetLabel.AutoSize = true;
            this.minBetLabel.Location = new System.Drawing.Point(13, 22);
            this.minBetLabel.Name = "minBetLabel";
            this.minBetLabel.Size = new System.Drawing.Size(119, 17);
            this.minBetLabel.TabIndex = 0;
            this.minBetLabel.Text = "minimumBetLabel";
            // 
            // raceTimer
            // 
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 609);
            this.Controls.Add(this.bettingParlour);
            this.Controls.Add(this.Greyhound4);
            this.Controls.Add(this.Greyhound3);
            this.Controls.Add(this.Greyhound2);
            this.Controls.Add(this.Greyhound1);
            this.Controls.Add(this.raceTrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Day At The Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound4)).EndInit();
            this.bettingParlour.ResumeLayout(false);
            this.bettingParlour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrackPictureBox;
        private System.Windows.Forms.PictureBox Greyhound1;
        private System.Windows.Forms.PictureBox Greyhound2;
        private System.Windows.Forms.PictureBox Greyhound3;
        private System.Windows.Forms.PictureBox Greyhound4;
        private System.Windows.Forms.GroupBox bettingParlour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minBetLabel;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.NumericUpDown betValue;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Timer raceTimer;
        private System.Windows.Forms.Button raceButton;
    }
}

