using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Guy
    {
        public string Name; //The guy's name
        public Bet MyBet; //An instance of Bet that has his bet
        public int Cash; //How much cash he has

        //The last two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton; //My RadioButton
        public Label MyLabel; //MyLabel

        public void UpdateLabels()
        {
            //Set my label to my bet's description, and the label on my
            //radio button to show my cash ("Joe has 43 bucks")      
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            MyLabel.Text = MyBet.GetDescription();


        }

        public bool PlaceBets(int BetAmount, int DogToWin)
        {
            //Place a new bet and store it in my bet field
            //Return true of the guy had enough money to bet
            if (BetAmount <= Cash)
            {
                MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };
                UpdateLabels();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void ClearBet() //Reset bet so it's zero
        {
            PlaceBets(0, 0);
        }

        public void Collect(int Winner)
        {
            //Ask my bet to pay out, clear my bet, and update my labels
            Cash += MyBet.PayOut(Winner);
            UpdateLabels();

        }
    }
}