using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models.ViewModel
{
    public class InvoiceViewModel
    {
        public string UserEmail { get; set;}
        public string UserName { get; set; }
        public double AmountToBePaid { get; set; }
        public string CarName { get; set; }
        public string BookingRef { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
