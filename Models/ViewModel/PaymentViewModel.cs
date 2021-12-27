using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models.ViewModel
{
    public class PaymentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string BookingRef { get; set; }
        public string TransactionId { get; set; }
        public Bookings Bookings { get; set; }
        public int BookingsId { get; set; }
        public int AmountPaid { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public DateTime DatePayed { get; set; }
    }
    public class CreatePaymentViewModel
    {
        public int Id { get; set; }
        public string BookingRef { get; set; }
        public string TransactionId { get; set; }
        public int BookingsId { get; set; }
        public int AmountPaid{ get; set; }
        public int CarId { get; set; }
        public DateTime DatePayed { get; set; }
    }
}
