using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
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


          
        [Authorize (Roles= "Admin,SuperAdmin")]  
        public IActionResult Index()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var loggedInUser = userService.FindUserById(userId);
            ViewBag.UserName = $"Welcome Admin {loggedInUser.FirstName} {loggedInUser.LastName}";
            var bookings = bookingsService.GetAll();
            return View(bookings);
        }
        [Authorize(Roles = "SuperAdmin,Admin")]
        public void Find(int id)
        {
            bookingsService.Find(id);
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult Delete(int id)
        {
            bookingsService.Delete(id);
            ViewBag.Message = "Delete Successfull";
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
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
        [HttpGet]
        public IActionResult BookingHistory()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var loggedInUser = userService.FindUserById(userId);
           var bookingHistory= bookingsService.BookingHistory(loggedInUser.Id);
            ViewBag.UserName = $"{loggedInUser.FirstName} {loggedInUser.LastName}";
            return View(bookingHistory);
        }
        [Authorize(Roles = "Admin, SuperAdmin")]

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
