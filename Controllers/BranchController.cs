using AimsCarRentals.Interfaces;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class BranchController : Controller
    {
        public readonly IBranchService branchService;
        public readonly IUserService userService;
        public BranchController(IBranchService branchService,IUserService userService)
        {
            this.branchService = branchService;
            this.userService = userService;
        }
        public IActionResult Index()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var loggedInUser = userService.FindUserById(userId);
            ViewBag.UserName = $" Welcome SuperAdmin {loggedInUser.FirstName} {loggedInUser.MiddleName} {loggedInUser.LastName}";
            var branch = branchService.GetAll();
            return View(branch);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateBranchViewModel createBranchViewModel)
        {
           branchService.AddBranch(createBranchViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateBranchViewModel model)
        {
            branchService.UpdateBranch(model);
            return RedirectToAction("Index");
        }
        public void Find(int id)
        {
            branchService.Find(id);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            branchService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var branch = branchService.Find(id);
            if (branch == null)
            {
                return NotFound();
            }
            return View(branch);
        }
        public IActionResult SelectBranch()
        {
            var branch = branchService.GetAll();
            return View(branch);
        }
    }
}
