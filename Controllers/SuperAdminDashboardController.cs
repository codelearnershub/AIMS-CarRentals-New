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
    public class SuperAdminDashboardController : Controller
    {
        public readonly IUserRepository _userRepository;
        public readonly IBranchService _branchService;
        public SuperAdminDashboardController(IUserRepository userRepository, IBranchService branchService)
        {
            _userRepository = userRepository;
            _branchService = branchService;
        }
        public IActionResult Index()
        { 
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

            User user = _userRepository.FindUserById(userId);

            SuperAdminDashBoard vm = new SuperAdminDashBoard
            {
                User = user
            };
            var branch = _branchService.GetAll();
            return View(branch);
        }
    }
}
