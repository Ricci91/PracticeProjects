using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6page266
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            Jewelthief jewelThief = new Jewelthief();
            jewelThief.OpenSafe(safe, owner);
            Console.ReadKey();
        }
    }
}
