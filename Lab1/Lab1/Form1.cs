using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyHoundArray = new Greyhound[4];
        Guy[] Guy = new Guy[3];
        Random MyRandomizer = new Random();
        
        public Form1()
        {
            InitializeComponent();

            minimumBetLabel.Text = "Minumum bet: " + bucksNumeric.Minimum + " bucks.";

            GreyHoundArray[0] = new Greyhound()
            {
                MyPictureBox = dogPicture1, 
                StartingPosition = dogPicture1.Left, 
                RaceTrackLength = racePictureBox.Width - dogPicture1.Width, 
                Randomizer = MyRandomizer
            };
            GreyHoundArray[1] = new Greyhound()
            {
                MyPictureBox = dogPicture2,
                StartingPosition = dogPicture2.Left,
                RaceTrackLength = racePictureBox.Width - dogPicture2.Width,
                Randomizer = MyRandomizer
            }; 
            GreyHoundArray[2] = new Greyhound()
            {
                MyPictureBox = dogPicture3,
                StartingPosition = dogPicture3.Left,
                RaceTrackLength = racePictureBox.Width - dogPicture3.Width,
                Randomizer = MyRandomizer
            }; 
            GreyHoundArray[3] = new Greyhound()
            {
                MyPictureBox = dogPicture4,
                StartingPosition = dogPicture4.Left,
                RaceTrackLength = racePictureBox.Width - dogPicture4.Width,
                Randomizer = MyRandomizer
            };

            Guy[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = joeRadioButton, MyLabel = joeBetLabel };
            Guy[1] = new Guy() { Name = "Bob", Cash = 70, MyRadioButton = bobRadioButton, MyLabel = bobBetLabel };
            Guy[2] = new Guy() { Name = "Al", Cash = 75, MyRadioButton = alRadioButton, MyLabel = alBetLabel };

            refreshGuyState();
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            nameLabel.Text = Guy[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            nameLabel.Text = Guy[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            nameLabel.Text = Guy[2].Name;
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyHoundArray.Length; i++)
            {
                GreyHoundArray[i].TakeStartingPosition();
            }
            groupBox1.Enabled = false;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Guy.Length; i++)
            {
                if (Guy[i].MyRadioButton.Checked)
                {
                    Guy[i].PlaceBet((int)bucksNumeric.Value, (int)dogNumeric.Value);
                    Guy[i].UpdateLabels();
                    
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int WinningDog = 0;
            for (int i = 0; i < GreyHoundArray.Length; i++)
            {
                
                if (GreyHoundArray[i].Run())
                {
                    timer1.Stop();
                    WinningDog = i + 1;
                    MessageBox.Show("Dog number: " + WinningDog + " wins the race!");
                    

                    for (int b = 0; b < Guy.Length; b++)
                    {
                        Guy[b].Collect(WinningDog);
                    }
                    
                    refreshGuyState();
                    groupBox1.Enabled = true;
                    break;
                }
            }
        }

        private void refreshGuyState()
        {
            for (int i = 0; i < Guy.Length; i++)
            {
                Guy[i].ClearBet();
            }
        }
    }
}
