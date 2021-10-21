using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using AimsCarRentals.Services;
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
        public IActionResult Index()
        {
            var category = categoryService.GetAllCategories();
            return View(category);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateCategoryViewModel createCategoryViewModel)
        {
            categoryService.AddCategory(createCategoryViewModel);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(UpdateCategoryViewModel updateCategoryViewModel)
        {
            categoryService.UpdateCategory(updateCategoryViewModel);
            return RedirectToAction("Index");
        }

        public void Find(int id)
        {
            categoryService.FindCategory(id);
        }
        public void Delete(int id)
        {
            categoryService.DeleteCategory(id);
            RedirectToAction("Index");
        }
    }
}
