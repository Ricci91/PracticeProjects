using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        Greyhound[] greyhound = new Greyhound[4];
        Guy[] guy = new Guy[3];
        Random myRandomizer = new Random();


        public Form1()
        {
            InitializeComponent();

            greyhound[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = myRandomizer
            };

            greyhound[1] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox2.Width,
                Randomizer = myRandomizer
            };

            greyhound[2] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width,
                Randomizer = myRandomizer
            };

            greyhound[3] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width,
                Randomizer = myRandomizer
            };

            guy[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = joeRadioButton, MyLabel = joeBetLabel };
            guy[1] = new Guy() { Name = "Bob", Cash = 70, MyRadioButton = bobRadioButton, MyLabel = bobBetLabel };
            guy[2] = new Guy() { Name = "Al", Cash = 75, MyRadioButton = alRadioButton, MyLabel = alBetLabel };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void refreshGuyState()
        {
            for (int i = 0; i < guy.Length; i++)
            {
                guy[i].ClearBet();
            }
        }
        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guy[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guy[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guy[2].Name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winningDog = 0;

            for (int i = 0; i < greyhound.Length; i++)
            {
                if (greyhound[i].Run())
                {
                    timer1.Stop();
                    winningDog = i + 1;
                    MessageBox.Show("Dog #" + winningDog + " won the race!");

                    for (int b = 0; b < guy.Length; b++)
                    {
                        guy[b].Collect(winningDog);
                    }

                    refreshGuyState();
                    bettingGroup.Enabled = true;
                    break;
                }

            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < greyhound.Length; c++)
            {
                greyhound[c].TakeStartingPosition();
            }
            bettingGroup.Enabled = false;
            timer1.Start();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)            
                guy[0].PlaceBets((int)cashBet.Value, (int)dogBet.Value);
            if (bobRadioButton.Checked)
                guy[1].PlaceBets((int)cashBet.Value, (int)dogBet.Value);
            if (alRadioButton.Checked)
                guy[2].PlaceBets((int)cashBet.Value, (int)dogBet.Value);               
            
        }

        private void minimumBetLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
