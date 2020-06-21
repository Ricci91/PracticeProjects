namespace ch5page224
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
            this.cowsLabel = new System.Windows.Forms.Label();
            this.numericCows = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCows)).BeginInit();
            this.SuspendLayout();
            // 
            // cowsLabel
            // 
            this.cowsLabel.AutoSize = true;
            this.cowsLabel.Location = new System.Drawing.Point(12, 22);
            this.cowsLabel.Name = "cowsLabel";
            this.cowsLabel.Size = new System.Drawing.Size(33, 13);
            this.cowsLabel.TabIndex = 0;
            this.cowsLabel.Text = "Cows";
            // 
            // numericCows
            // 
            this.numericCows.Location = new System.Drawing.Point(52, 22);
            this.numericCows.Name = "numericCows";
            this.numericCows.Size = new System.Drawing.Size(120, 20);
            this.numericCows.TabIndex = 1;
            this.numericCows.ValueChanged += new System.EventHandler(this.numericCows_ValueChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(52, 54);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 89);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numericCows);
            this.Controls.Add(this.cowsLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cow Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericCows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cowsLabel;
        private System.Windows.Forms.NumericUpDown numericCows;
        private System.Windows.Forms.Button calculateButton;
    }
}

