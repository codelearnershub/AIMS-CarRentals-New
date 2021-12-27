using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.ServiceInterfaces
{
    public interface IBookingsService
    {
        public Bookings AddBookings(CreateBookingsViewModel model, Car car, User user);
        public Bookings Delete(int id);
        public Bookings Find(int id);
        public List<BookingsViewModel> GetAll();
        public List<Bookings> BookingHistory(int userId);
        public Bookings VerifyCar(string booking_Ref, Bookings bookings);
        public Bookings FindByBookingRef(string booking_Ref);
    }
}
