using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classProgram1
{
    public class Request
    {
        public string PhoneNumber { get; }
        public DateTime DateTime { get; }

        public List<Product> Products { get; set; }

        public Request(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
            DateTime = DateTime.Now;
            Products = new List<Product>();
        }
    }
}
