using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models
{
    public class Payment 
    {
        public int Id { get; set; }
        public string TransactionRef { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public double AmountPaid { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
