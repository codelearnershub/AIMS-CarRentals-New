using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class BookingsController : Controller
    {
        public readonly IBookingsService bookingsService;
        public readonly IUserService userService;

        public BookingsController(IBookingsService bookingsService, IUserService userService)
        {
            this.bookingsService = bookingsService;
            this.userService = userService;
        }
        public IActionResult Index()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var loggedInUser = userService.FindUserById(userId);
            ViewBag.UserName = $"Welcome Admin {loggedInUser.FirstName} {loggedInUser.LastName}";
            var bookings = bookingsService.GetAll();
            return View(bookings);
        }
        public void Find(int id)
        {
            bookingsService.Find(id);
        }
        public IActionResult Delete(int id)
        {
            bookingsService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var bookings = bookingsService.Find(id);
            if (bookings != null)
            {
                return View(bookings);
            }
            return NotFound();
        }
        public IActionResult BookingHistory()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var loggedInUser = userService.FindUserById(userId);
            bookingsService.BookingHistory(userId);
            ViewBag.UserName = $"{loggedInUser.FirstName} {loggedInUser.LastName}";
            return RedirectToAction("Index", "Home");
        }
        public IActionResult VerifyCar(string booking_Ref, Bookings bookings)
        {
            var bookingref = bookingsService.FindByBookingRef(booking_Ref);

            if (bookingref == null)
            {
                ViewBag.Message = "Invalid Code";
                return null;
            }
            else if (bookingref != null && bookingref.IsVerified == true)
            {
                ViewBag.Message = "This booking ref has been used";
            }
            bookingsService.VerifyCar(booking_Ref, bookings);
            return RedirectToAction("Index", "Branch");


        }
    } 
}
