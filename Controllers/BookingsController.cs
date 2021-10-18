using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class BookingsController : Controller
    {
        public readonly IBookingsService bookingsService;

        public BookingsController(IBookingsService bookingsService)
        {
            this.bookingsService = bookingsService;
        }
        public IActionResult Index()
        {
            var bookings = bookingsService.GetAll();
            return View(bookings);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateBookingsViewModel createBookingsViewModel)
        {
            bookingsService.AddBookings(createBookingsViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(UpdateBookingsViewModel updateBookingsViewModel)
        {
            bookingsService.UpdateBookings(updateBookingsViewModel);
            return RedirectToAction("Index");
        }

        public void Find(int id)
        {
            bookingsService.Find(id);
        }
        public void Delete(int id)
        {
            bookingsService.Delete(id);
        }
    }
}
