using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class BranchController : Controller
    {
        public readonly IBranchService branchService;
      
        public BranchController(IBranchService branchService)
        {
            this.branchService = branchService;
        }
        public IActionResult Index()
        {
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
        [ValidateAntiForgeryToken]
        public IActionResult Update(UpdateBranchViewModel updateBranchViewModel)
        {
            branchService.UpdateBranch(updateBranchViewModel);
            return RedirectToAction("Index");
        }

        public void Find(int id)
        {
            branchService.Find(id);
        }
        public void Delete(int id)
        {
            branchService.Delete(id);
        }
    }
}
