﻿namespace BeeHiveManagementv2
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
            this.report = new System.Windows.Forms.TextBox();
            this.workButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftsNumeric = new System.Windows.Forms.NumericUpDown();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 119);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(480, 187);
            this.report.TabIndex = 5;
            // 
            // workButton
            // 
            this.workButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workButton.Location = new System.Drawing.Point(323, 17);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(169, 95);
            this.workButton.TabIndex = 4;
            this.workButton.Text = "Work the next shift";
            this.workButton.UseVisualStyleBackColor = true;
            this.workButton.Click += new System.EventHandler(this.workButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.shiftsNumeric);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(10, 65);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(284, 23);
            this.assignButton.TabIndex = 4;
            this.assignButton.Text = "Assign this job to a bee";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shifts";
            // 
            // shiftsNumeric
            // 
            this.shiftsNumeric.Location = new System.Drawing.Point(174, 37);
            this.shiftsNumeric.Name = "shiftsNumeric";
            this.shiftsNumeric.Size = new System.Drawing.Size(120, 20);
            this.shiftsNumeric.TabIndex = 2;
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(10, 37);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(157, 21);
            this.workerBeeJob.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 315);
            this.Controls.Add(this.report);
            this.Controls.Add(this.workButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown shiftsNumeric;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Label label1;
    }
}

