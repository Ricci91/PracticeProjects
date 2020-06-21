namespace ch4page151
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amountOwedf = new System.Windows.Forms.Label();
            this.startingMileagef = new System.Windows.Forms.NumericUpDown();
            this.endingMileagef = new System.Windows.Forms.NumericUpDown();
            this.calculateOwed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startingMileagef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingMileagef)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Mileage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ending Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Owed";
            // 
            // amountOwedf
            // 
            this.amountOwedf.AutoSize = true;
            this.amountOwedf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOwedf.Location = new System.Drawing.Point(123, 94);
            this.amountOwedf.Name = "amountOwedf";
            this.amountOwedf.Size = new System.Drawing.Size(57, 20);
            this.amountOwedf.TabIndex = 3;
            this.amountOwedf.Text = "label4";
            // 
            // startingMileagef
            // 
            this.startingMileagef.Location = new System.Drawing.Point(112, 29);
            this.startingMileagef.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.startingMileagef.Name = "startingMileagef";
            this.startingMileagef.Size = new System.Drawing.Size(120, 20);
            this.startingMileagef.TabIndex = 4;
            // 
            // endingMileagef
            // 
            this.endingMileagef.Location = new System.Drawing.Point(112, 56);
            this.endingMileagef.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.endingMileagef.Name = "endingMileagef";
            this.endingMileagef.Size = new System.Drawing.Size(120, 20);
            this.endingMileagef.TabIndex = 5;
            // 
            // calculateOwed
            // 
            this.calculateOwed.Location = new System.Drawing.Point(12, 137);
            this.calculateOwed.Name = "calculateOwed";
            this.calculateOwed.Size = new System.Drawing.Size(107, 34);
            this.calculateOwed.TabIndex = 6;
            this.calculateOwed.Text = "Calculate";
            this.calculateOwed.UseVisualStyleBackColor = true;
            this.calculateOwed.Click += new System.EventHandler(this.calculateOwed_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Display Miles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calculateOwed);
            this.Controls.Add(this.endingMileagef);
            this.Controls.Add(this.startingMileagef);
            this.Controls.Add(this.amountOwedf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.startingMileagef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingMileagef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label amountOwedf;
        private System.Windows.Forms.NumericUpDown startingMileagef;
        private System.Windows.Forms.NumericUpDown endingMileagef;
        private System.Windows.Forms.Button calculateOwed;
        private System.Windows.Forms.Button button1;
    }
}

