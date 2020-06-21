using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPluralsightKurs
{
    class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        public Customer[] ReadFirstNCustomers(int nCustomers)
        {
            Customer[] customers = new Customer[nCustomers];

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();
                for (int i = 0; i < nCustomers; i++)
                {
                    string csvLine = sr.ReadLine();
                    customers[i] = ReadCustomerFromCsvLine(csvLine);
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
