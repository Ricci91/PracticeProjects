using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPluralsightKursDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new Dictionary<string, string>();
            customers.Add("Aibel AS", "sanja.nilsen@evry.com");
            customers.Add("Altus Intervention", "tommy.hobberstad@evry.com");

            string selectedCustomer = customers["Aibel AS"];

            Console.WriteLine(selectedCustomer);


        }
    }
}
