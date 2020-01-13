using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetails_IFSC.Models
{
    public class BankDetails
    {
    
        public string bank { get; set; }
        public string IFSC { get; set; }
        public string MICR { get; set; }
        public string branch { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
    }
}
