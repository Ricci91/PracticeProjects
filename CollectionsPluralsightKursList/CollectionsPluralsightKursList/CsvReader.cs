using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPluralsightKursList
{
    class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        public List<Customer> ReadAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();

                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    customers.Add(ReadCustomerFromCsvLine(csvLine));
                }
            }

            return customers;
        }

        public Customer ReadCustomerFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            string customer = parts[0];
            string slm = parts[1];

            return new Customer(customer, slm);
        }
    }
}
