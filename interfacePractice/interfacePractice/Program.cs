using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallguy = new TallGuy() { Heigth = 74, Name = "Jimmy" };
            tallguy.TalkAboutYourself();
            tallguy.Honk(); 
        }
    }
}
