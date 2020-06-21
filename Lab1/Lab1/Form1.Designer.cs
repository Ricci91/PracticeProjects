namespace Lab1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raceButton = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.betsLabel = new System.Windows.Forms.Label();
            this.dogNumeric = new System.Windows.Forms.NumericUpDown();
            this.bucksOnDogNumber = new System.Windows.Forms.Label();
            this.bucksNumeric = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.dogPicture1 = new System.Windows.Forms.PictureBox();
            this.racePictureBox = new System.Windows.Forms.PictureBox();
            this.dogPicture2 = new System.Windows.Forms.PictureBox();
            this.dogPicture3 = new System.Windows.Forms.PictureBox();
            this.dogPicture4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raceButton);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.betsLabel);
            this.groupBox1.Controls.Add(this.dogNumeric);
            this.groupBox1.Controls.Add(this.bucksOnDogNumber);
            this.groupBox1.Controls.Add(this.bucksNumeric);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(1, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(403, 30);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(163, 107);
            this.raceButton.TabIndex = 13;
            this.raceButton.Text = "RACE!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(150, 87);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(57, 13);
            this.alBetLabel.TabIndex = 12;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(152, 65);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(67, 13);
            this.bobBetLabel.TabIndex = 11;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Location = new System.Drawing.Point(149, 41);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(63, 13);
            this.joeBetLabel.TabIndex = 10;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Location = new System.Drawing.Point(149, 20);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(28, 13);
            this.betsLabel.TabIndex = 9;
            this.betsLabel.Text = "Bets";
            // 
            // dogNumeric
            // 
            this.dogNumeric.Location = new System.Drawing.Point(308, 122);
            this.dogNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumeric.Name = "dogNumeric";
            this.dogNumeric.Size = new System.Drawing.Size(30, 20);
            this.dogNumeric.TabIndex = 8;
            this.dogNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bucksOnDogNumber
            // 
            this.bucksOnDogNumber.AutoSize = true;
            this.bucksOnDogNumber.Location = new System.Drawing.Point(192, 124);
            this.bucksOnDogNumber.Name = "bucksOnDogNumber";
            this.bucksOnDogNumber.Size = new System.Drawing.Size(110, 13);
            this.bucksOnDogNumber.TabIndex = 7;
            this.bucksOnDogNumber.Text = "bucks on dog number";
            // 
            // bucksNumeric
            // 
            this.bucksNumeric.Location = new System.Drawing.Point(155, 122);
            this.bucksNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bucksNumeric.Name = "bucksNumeric";
            this.bucksNumeric.Size = new System.Drawing.Size(30, 20);
            this.bucksNumeric.TabIndex = 6;
            this.bucksNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(74, 119);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(75, 23);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 124);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "nameLabel";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(7, 85);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(7, 61);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(7, 37);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(7, 20);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(104, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // dogPicture1
            // 
            this.dogPicture1.Image = global::Lab1.Properties.Resources.dog__1_;
            this.dogPicture1.Location = new System.Drawing.Point(1, 12);
            this.dogPicture1.Name = "dogPicture1";
            this.dogPicture1.Size = new System.Drawing.Size(81, 25);
            this.dogPicture1.TabIndex = 13;
            this.dogPicture1.TabStop = false;
            // 
            // racePictureBox
            // 
            this.racePictureBox.Image = global::Lab1.Properties.Resources.racetrack__1_;
            this.racePictureBox.Location = new System.Drawing.Point(1, 2);
            this.racePictureBox.Name = "racePictureBox";
            this.racePictureBox.Size = new System.Drawing.Size(603, 206);
            this.racePictureBox.TabIndex = 0;
            this.racePictureBox.TabStop = false;
            // 
            // dogPicture2
            // 
            this.dogPicture2.Image = global::Lab1.Properties.Resources.dog__1_;
            this.dogPicture2.Location = new System.Drawing.Point(1, 59);
            this.dogPicture2.Name = "dogPicture2";
            this.dogPicture2.Size = new System.Drawing.Size(81, 25);
            this.dogPicture2.TabIndex = 14;
            this.dogPicture2.TabStop = false;
            // 
            // dogPicture3
            // 
            this.dogPicture3.Image = global::Lab1.Properties.Resources.dog__1_;
            this.dogPicture3.Location = new System.Drawing.Point(1, 115);
            this.dogPicture3.Name = "dogPicture3";
            this.dogPicture3.Size = new System.Drawing.Size(81, 25);
            this.dogPicture3.TabIndex = 15;
            this.dogPicture3.TabStop = false;
            // 
            // dogPicture4
            // 
            this.dogPicture4.Image = global::Lab1.Properties.Resources.dog__1_;
            this.dogPicture4.Location = new System.Drawing.Point(1, 166);
            this.dogPicture4.Name = "dogPicture4";
            this.dogPicture4.Size = new System.Drawing.Size(81, 25);
            this.dogPicture4.TabIndex = 16;
            this.dogPicture4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 399);
            this.Controls.Add(this.dogPicture4);
            this.Controls.Add(this.dogPicture3);
            this.Controls.Add(this.dogPicture2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dogPicture1);
            this.Controls.Add(this.racePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racePictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox dogPicture1;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.NumericUpDown dogNumeric;
        private System.Windows.Forms.Label bucksOnDogNumber;
        private System.Windows.Forms.NumericUpDown bucksNumeric;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.PictureBox dogPicture2;
        private System.Windows.Forms.PictureBox dogPicture3;
        private System.Windows.Forms.PictureBox dogPicture4;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Timer timer1;
    }
}

