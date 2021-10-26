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
        public readonly IBookingsRepository bookingsRepository;
        public readonly ICarService carService;
        public readonly ICarRepository carRepository;
        public BookingsService(IBookingsRepository bookingsRepository,ICarService carService, ICarRepository carRepository)
        {
            this.bookingsRepository = bookingsRepository;
            this.carService = carService;
            this.carRepository = carRepository;
        }
        public Bookings AddBookings(CreateBookingsViewModel model,Car car, User user)
        {
            var bookings = new Bookings
            {
                Booking_ref = model.Booking_ref,
                UserId = model.UserId,
                User = user,
                Car = car,
                CarId = model.CarId,
                PickUpDate = model.PickUpDate,
                ReturnDate = model.ReturnDate,
                CreatedAt = DateTime.Now
            };
            var carAvailable = carService.Find(car.Id);
            carAvailable.IsAvailable = false;

            carRepository.UpdateCar(carAvailable);

            return bookingsRepository.AddBookings(bookings);
        }
        public Bookings UpdateBookings(UpdateBookingsViewModel model)
        {
            var bookings = new Bookings
            {
                Booking_ref = model.Booking_ref,
                UserId = model.UserId,
                CarId = model.CarId,
                PickUpDate = model.PickUpDate,
                ReturnDate = model.ReturnDate,
                CreatedAt = DateTime.Now
            };
            return bookings;
        }
        public Bookings Delete(int id)
        {
            return bookingsRepository.Delete(id);
        }
        public Bookings Find(int id)
        {
            return bookingsRepository.Find(id);
        }
        public List<BookingsViewModel> GetAll()
        {
            var branch = bookingsRepository.GetAll().Select(c => new BookingsViewModel
            {
                Booking_ref = c.Booking_ref,
                UserId = c.UserId,
                CarId = c.CarId,
                PickUpDate = c.PickUpDate,
                ReturnDate = c.ReturnDate,
                CreatedAt = DateTime.Now
            }).ToList();
            return branch;
        }
        public List<Bookings> BookingHistory(int userId)
        {
           return bookingsRepository.BookingHistory(userId);
        }
    }
}
