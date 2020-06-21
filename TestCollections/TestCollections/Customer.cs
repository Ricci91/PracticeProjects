using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollections
{
    class Customer
    {
        public string CustomerName { get; set; }
        public string Slm { get; set; }
        
        public Customer(string customername, string slm)
        {
            CustomerName = customername;
            Slm = slm;
        }
    }
}
