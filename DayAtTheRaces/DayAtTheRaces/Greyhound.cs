using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition; //Where my PictureBox starts
        public int RacetrackLength; //How long the racetrack is
        public PictureBox MyPictureBox = null; //My Picturebox object
        public int Location = 0; //My location on the racetrack
        public Random Randomizer; //An instance of random



        public bool Run()
        {
            //Move forward either 1, 2, 3 or 4 spaces at random
            Location += Randomizer.Next(4);            
            //update the position of my picturebox on the form like this:
            //MypictureBox.Left = StartingPosition + Location;
            MyPictureBox.Left = StartingPosition + Location;
            //return true if I won the race
            MyPictureBox.Refresh();
            if (MyPictureBox.Left >= RacetrackLength - MyPictureBox.Width + 20)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
            
        }
    }
}