using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;


        public string GetDescription()
        {

            if (Amount > 0)
            {
                return Bettor.Name + " bets " + Amount + " on " + Dog;
            }
            else
            {

                return Bettor + " hasn't placed a bet";
            }
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog)
                {
                    return Amount;
                }
                else
                {
                    return -Amount;
                }
        }
    }
}