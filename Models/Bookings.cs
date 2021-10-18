using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models
{
    public class Bookings:BaseEntity
    {
        [Key]
        public string Booking_ref { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime ReturnDate { get; set; }
       // public string Status { get; set; }
       public bool ISPaid { get; set; }
    }
}
