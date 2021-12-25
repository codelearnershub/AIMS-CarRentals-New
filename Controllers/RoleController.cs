using AimsCarRentals.Interfaces;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class RoleController : Controller
    {
        public readonly IRoleService roleService;
        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult Index()
        {
            var branch = roleService.GetAllRole();
            return View(branch);

        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateRoleViewModel createRoleViewModel)
        {
            roleService.AddRole(createRoleViewModel);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(UpdateRoleViewModel updateRoleViewModel)
        {
            roleService.UpdateRole(updateRoleViewModel);
            return RedirectToAction("Index");
        }

        public void Find(int id)
        {
            roleService.FindRole(id);
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public void Delete(int id)
        {
            roleService.DeleteRole(id);
            RedirectToAction("Index"); 
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult Details(int id)
        {
            var role = roleService.FindRole(id);
            if (role == null)
            {
                return NotFound();
            }
            return View(role);
        }
    }
}
