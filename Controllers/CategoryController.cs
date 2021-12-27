using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using AimsCarRentals.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult Index()
        {
            var category = categoryService.GetAllCategories();
            return View(category);

        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateCategoryViewModel model)
        {
            if(model == null)
            {
                ViewBag.Message = "Cannot Created Successfully";
            }
            categoryService.AddCategory(model);       
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(UpdateCategoryViewModel updateCategoryViewModel)
        {
            if(updateCategoryViewModel == null)
            {
                ViewBag.Message = "Cannot update Successfully";
            }
            categoryService.UpdateCategory(updateCategoryViewModel);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public void Find(int id)
        {
            categoryService.FindCategory(id);
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public void Delete(int id)
        {
            categoryService.DeleteCategory(id);
            RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult Details(int id)
        {
            var category = categoryService.FindCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult SelectCategory()
        {
            var category = categoryService.GetAllCategories();
            return View(category);
        }
    }
}
