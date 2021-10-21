using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class SuperAdminDashboardController : Controller
    {
        public readonly IUserRepository _userRepository;
        public SuperAdminDashboardController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        { 
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

            User user = _userRepository.FindUserById(userId);

            SuperAdminDashBoard vm = new SuperAdminDashBoard
            {
                User = user
            };
            return View();
        }
    }
}
