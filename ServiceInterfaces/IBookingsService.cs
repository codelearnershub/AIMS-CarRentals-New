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
        public Bookings AddBookings(CreateBookingsViewModel model);
        public Bookings UpdateBookings(UpdateBookingsViewModel model);
        public Bookings Delete(int id);
        public Bookings Find(int id);
        public List<BookingsViewModel> GetAll();
    }
}
