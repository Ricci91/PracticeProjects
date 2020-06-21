using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveManagement
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufactoring",
            "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol"});
            queen = new Queen(workers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void shiftsNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shiftsNumeric.Value) == false)
                MessageBox.Show("No workers are available to do this job ' "
                    + workerBeeJob.Text + "'", "The queen bee says...");
            else
                MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in " + shiftsNumeric.Value + " shifts.", "The queen bee says...");
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void workerBeeJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
