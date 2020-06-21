using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch5page200
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numPeopleNumeric.Value, healthyCheckbox.Checked, fancyCheckbox.Checked);

            DisplayDinnerPartyCost();
            
        }

        private void fancyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyCheckbox.Checked;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            textBox1.Text = Cost.ToString("c");
        }

        private void numPeopleNumeric_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numPeopleNumeric.Value;
            DisplayDinnerPartyCost();
        }

        private void healthyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyCheckbox.Checked;
            DisplayDinnerPartyCost();
        }
    }
}
