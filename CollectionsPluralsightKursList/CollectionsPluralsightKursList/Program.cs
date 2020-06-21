using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPluralsightKursList
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\froyl\Documents\customerSlm.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Customer> customers = reader.ReadAllCustomers();
            foreach (Customer customer in customers)
                Console.WriteLine($"{customer.Customers}: {customer.Slm}");
        }
    }
}
