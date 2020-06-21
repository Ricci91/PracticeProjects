namespace ch6page240
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.healthyCheckbox = new System.Windows.Forms.CheckBox();
            this.fancyCheckbox = new System.Windows.Forms.CheckBox();
            this.numPeopleNumeric = new System.Windows.Forms.NumericUpDown();
            this.numPeopleLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleNumeric)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(277, 274);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.healthyCheckbox);
            this.tabPage1.Controls.Add(this.fancyCheckbox);
            this.tabPage1.Controls.Add(this.numPeopleNumeric);
            this.tabPage1.Controls.Add(this.numPeopleLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(269, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(1, 143);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(36, 13);
            this.costLabel.TabIndex = 10;
            this.costLabel.Text = "Cost:";
            // 
            // healthyCheckbox
            // 
            this.healthyCheckbox.AutoSize = true;
            this.healthyCheckbox.Location = new System.Drawing.Point(23, 86);
            this.healthyCheckbox.Name = "healthyCheckbox";
            this.healthyCheckbox.Size = new System.Drawing.Size(96, 17);
            this.healthyCheckbox.TabIndex = 9;
            this.healthyCheckbox.Text = "Healthy Option";
            this.healthyCheckbox.UseVisualStyleBackColor = true;
            this.healthyCheckbox.CheckedChanged += new System.EventHandler(this.healthyCheckbox_CheckedChanged);
            // 
            // fancyCheckbox
            // 
            this.fancyCheckbox.AutoSize = true;
            this.fancyCheckbox.Location = new System.Drawing.Point(23, 62);
            this.fancyCheckbox.Name = "fancyCheckbox";
            this.fancyCheckbox.Size = new System.Drawing.Size(115, 17);
            this.fancyCheckbox.TabIndex = 8;
            this.fancyCheckbox.Text = "Fancy Decorations";
            this.fancyCheckbox.UseVisualStyleBackColor = true;
            this.fancyCheckbox.CheckedChanged += new System.EventHandler(this.fancyCheckbox_CheckedChanged);
            // 
            // numPeopleNumeric
            // 
            this.numPeopleNumeric.Location = new System.Drawing.Point(23, 19);
            this.numPeopleNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numPeopleNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPeopleNumeric.Name = "numPeopleNumeric";
            this.numPeopleNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numPeopleNumeric.Size = new System.Drawing.Size(120, 20);
            this.numPeopleNumeric.TabIndex = 7;
            this.numPeopleNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPeopleNumeric.ValueChanged += new System.EventHandler(this.numPeopleNumeric_ValueChanged);
            // 
            // numPeopleLabel
            // 
            this.numPeopleLabel.AutoSize = true;
            this.numPeopleLabel.Location = new System.Drawing.Point(20, 3);
            this.numPeopleLabel.Name = "numPeopleLabel";
            this.numPeopleLabel.Size = new System.Drawing.Size(92, 13);
            this.numPeopleLabel.TabIndex = 6;
            this.numPeopleLabel.Text = "Number of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(269, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.Location = new System.Drawing.Point(85, 94);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.tooLongLabel.TabIndex = 20;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(13, 112);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(186, 20);
            this.cakeWriting.TabIndex = 19;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cake Writing";
            // 
            // birthdayCost
            // 
            this.birthdayCost.Location = new System.Drawing.Point(52, 140);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(100, 20);
            this.birthdayCost.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cost:";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(32, 62);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.fancyBirthday.TabIndex = 14;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(32, 19);
            this.numberBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numberBirthday.Size = new System.Drawing.Size(120, 20);
            this.numberBirthday.TabIndex = 13;
            this.numberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 289);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleNumeric)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.CheckBox healthyCheckbox;
        private System.Windows.Forms.CheckBox fancyCheckbox;
        private System.Windows.Forms.NumericUpDown numPeopleNumeric;
        private System.Windows.Forms.Label numPeopleLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox birthdayCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label2;
    }
}

