using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    class TallGuy : IClown
    {
        public string Name;
        public int Heigth;

        public string FunnyThingIHave
        {
            get
            {
                return "big shoes";
            }           

        }
        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Heigth + " inches tall.");
        }

        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }

        
    }
}
