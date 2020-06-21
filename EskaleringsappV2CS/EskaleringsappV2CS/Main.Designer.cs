namespace EskaleringsappV2CS
{
    partial class Main
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
            this.informSimaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informSimaButton
            // 
            this.informSimaButton.Location = new System.Drawing.Point(359, 57);
            this.informSimaButton.Name = "informSimaButton";
            this.informSimaButton.Size = new System.Drawing.Size(137, 57);
            this.informSimaButton.TabIndex = 0;
            this.informSimaButton.Text = "Inform Sima";
            this.informSimaButton.UseVisualStyleBackColor = true;
            this.informSimaButton.Click += new System.EventHandler(this.informSimaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.informSimaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button informSimaButton;
    }
}

