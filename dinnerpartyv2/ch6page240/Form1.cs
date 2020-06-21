using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch6page240
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numPeopleNumeric.Value, healthyCheckbox.Checked, fancyCheckbox.Checked);

            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);

            DisplayBirthdayPartyCost();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void numPeopleNumeric_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numPeopleNumeric.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyCheckbox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyCheckbox.Checked;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            textBox1.Text = Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal Cost = birthdayParty.Cost;
            birthdayCost.Text = Cost.ToString("c");
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
