using AimsCarRentals.Interfaces;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult Index()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var loggedInUser = userService.FindUserById(userId);
            ViewBag.UserName = $" Welcome SuperAdmin {loggedInUser.FirstName} {loggedInUser.MiddleName} {loggedInUser.LastName}";
            var branch = branchService.GetAll();
            return View(branch);
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize (Roles ="Admin, SuperAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateBranchViewModel createBranchViewModel)
        {
             if(createBranchViewModel == null)
            {
                ViewBag.Message = "Can not Create Branch";
                return null;
            }
            branchService.AddBranch(createBranchViewModel);
           
           return RedirectToAction("Index");
            
            

        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateBranchViewModel model)
        {
            if(model == null)
            {
                ViewBag.Message = "Cannot Update Branch";
                return null;
            }
            branchService.UpdateBranch(model);
            ViewBag.Message = "Updated Successfully";
            return RedirectToAction("Index");
        }
        public void Find(int id)
        {
            branchService.Find(id);
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var delete = branchService.Find(id);
            if (delete == null)
            {
                ViewBag.Message = "Can not delete branch";
                return NotFound();
            }
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {

            branchService.Delete(id);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
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
