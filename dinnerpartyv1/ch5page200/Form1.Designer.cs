namespace ch5page200
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
            this.numPeopleLabel = new System.Windows.Forms.Label();
            this.numPeopleNumeric = new System.Windows.Forms.NumericUpDown();
            this.fancyCheckbox = new System.Windows.Forms.CheckBox();
            this.healthyCheckbox = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // numPeopleLabel
            // 
            this.numPeopleLabel.AutoSize = true;
            this.numPeopleLabel.Location = new System.Drawing.Point(56, 13);
            this.numPeopleLabel.Name = "numPeopleLabel";
            this.numPeopleLabel.Size = new System.Drawing.Size(92, 13);
            this.numPeopleLabel.TabIndex = 0;
            this.numPeopleLabel.Text = "Number of People";
            // 
            // numPeopleNumeric
            // 
            this.numPeopleNumeric.Location = new System.Drawing.Point(59, 29);
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
            this.numPeopleNumeric.TabIndex = 1;
            this.numPeopleNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPeopleNumeric.ValueChanged += new System.EventHandler(this.numPeopleNumeric_ValueChanged);
            // 
            // fancyCheckbox
            // 
            this.fancyCheckbox.AutoSize = true;
            this.fancyCheckbox.Location = new System.Drawing.Point(59, 72);
            this.fancyCheckbox.Name = "fancyCheckbox";
            this.fancyCheckbox.Size = new System.Drawing.Size(115, 17);
            this.fancyCheckbox.TabIndex = 2;
            this.fancyCheckbox.Text = "Fancy Decorations";
            this.fancyCheckbox.UseVisualStyleBackColor = true;
            this.fancyCheckbox.CheckedChanged += new System.EventHandler(this.fancyCheckbox_CheckedChanged);
            // 
            // healthyCheckbox
            // 
            this.healthyCheckbox.AutoSize = true;
            this.healthyCheckbox.Location = new System.Drawing.Point(59, 96);
            this.healthyCheckbox.Name = "healthyCheckbox";
            this.healthyCheckbox.Size = new System.Drawing.Size(96, 17);
            this.healthyCheckbox.TabIndex = 3;
            this.healthyCheckbox.Text = "Healthy Option";
            this.healthyCheckbox.UseVisualStyleBackColor = true;
            this.healthyCheckbox.CheckedChanged += new System.EventHandler(this.healthyCheckbox_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(37, 153);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(36, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 235);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.healthyCheckbox);
            this.Controls.Add(this.fancyCheckbox);
            this.Controls.Add(this.numPeopleNumeric);
            this.Controls.Add(this.numPeopleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numPeopleLabel;
        private System.Windows.Forms.NumericUpDown numPeopleNumeric;
        private System.Windows.Forms.CheckBox fancyCheckbox;
        private System.Windows.Forms.CheckBox healthyCheckbox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

