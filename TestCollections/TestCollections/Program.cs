using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace TestCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerPrint();
        }

        public static List<Customer> ReadAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (var reader = new StreamReader(@"C:\Users\froyl\Documents\customerSlm2.csv"))
            {
                reader.ReadLine();
                string csvLine;
                while ((csvLine = reader.ReadLine()) != null)
                    customers.Add(ReadCustomerFromCsvLine(csvLine));
            }
            return customers;
        }

        public static Customer ReadCustomerFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            string name = parts[0];
            string slm = parts[1];

            return new Customer(name, slm);
        }

        public static void CustomerPrint()
        {
            List<Customer> customers = ReadAllCustomers();

            for (int i = 0; i < customers.Count; i++)
            {
                Customer customer = customers[i];
                /*Console.WriteLine($"Customer:{customer.CustomerName} ** Slm Email: {customer.Slm}");*/
                Console.WriteLine(customer.CustomerName);
            }

            string chosenCust = customers[2];
        }
    }
}
