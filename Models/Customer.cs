using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models
{
    public class Customer
    {
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
