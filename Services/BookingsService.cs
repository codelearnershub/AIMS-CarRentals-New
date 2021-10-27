using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Services
{
    public class BookingsService:IBookingsService
    {

        private readonly IBookingsRepository _bookingsRepository;
        private readonly ICarService _carService;
        private readonly ICarRepository _carRepository;

        public BookingsService(IBookingsRepository bookingsRepository, ICarService carService, ICarRepository carRepository)
        {
            _bookingsRepository = bookingsRepository;
            _carService = carService;
            _carRepository = carRepository;
        }
        public Bookings AddBookings(CreateBookingsViewModel model, Car car, User user)
        {

            var bookings = new Bookings
            {
                Booking_ref = Guid.NewGuid().ToString().Substring(0, 7),
                UserId = model.UserId,
                User = user,
                CarId = model.CarId,
                Car = car,
                PickUpDate = model.PickUpDate,
                ReturnDate = model.ReturnDate,
                CreatedAt = DateTime.Now,
            };
            var carAvailable = _carService.Find(car.Id);
            carAvailable.IsAvailable = false;

            _carRepository.UpdateCar(carAvailable);

            return _bookingsRepository.AddBookings(bookings);
        }
        
        public Bookings Find(int id)
        {
            return _bookingsRepository.Find(id);
        }
        public List<Bookings> BookingHistory(int userId)
        {
            return _bookingsRepository.BookingHistory(userId);
        }

        public Bookings Delete(int id)
        {
            return _bookingsRepository.Delete(id);
        }
        public List<BookingsViewModel> GetAll()
        {
            var bookings = _bookingsRepository.GetAll().Select(c => new BookingsViewModel
            {
                Booking_ref = Guid.NewGuid().ToString().Substring(0, 7),
                UserId = c.UserId,
                CarId = c.CarId,
                PickUpDate = c.PickUpDate,
                ReturnDate = c.ReturnDate,
                CreatedAt = c.CreatedAt,
            }).ToList();
            return bookings;
        }
    }
}
