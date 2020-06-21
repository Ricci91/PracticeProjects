using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiftSimulator
{
    public partial class Form1 : Form
    {
        private Leader leader;
        public Form1()
        {
            InitializeComponent();
            workerJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "DokumentasjonSkriving", "Telefoni" });
            workers[1] = new Worker(new string[] { "Telefoni", "FIM" });
            workers[2] = new Worker(new string[] { "Overvåkning", "Telefoni", "FIM" });
            workers[3] = new Worker(new string[] { "DokumentasjonSkriving", "FIM", "Automatisering" });
            leader = new Leader(workers);
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = leader.WorkTheNextShift();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (leader.AssignWork(workerJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("No workers are available to do the job '" + workerJob.Text + "'", "The Leader says...");
            else
                MessageBox.Show("The job '" + workerJob.Text + "' will be done in " + shifts.Value + " shifts.", "The leader says...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
