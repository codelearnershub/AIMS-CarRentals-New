using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
    public interface IBookingsRepository
    {
        public Bookings AddBookings(Bookings bookings);
        public Bookings UpdateBookings(Bookings bookings);
        public Bookings Find(int id);
        public Bookings Delete(int id);
        public List<Bookings> BookingHistory(int userId);
        public List<Bookings> GetAll();
        public Bookings FindByBookingRef(string booking_ref);
    }
}

