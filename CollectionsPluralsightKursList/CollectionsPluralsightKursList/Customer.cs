using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPluralsightKursList
{
    class Customer
    {
        public string Customers { get; }
        public string Slm { get; }

        public Customer(string customer, string slm)
        {
            this.Customers = customer;
            this.Slm = slm;
        }
    }
    

}
