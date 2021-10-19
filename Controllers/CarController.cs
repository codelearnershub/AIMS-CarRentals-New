﻿using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class CarController : Controller
    {
        public readonly ICarService carService;
        private readonly IWebHostEnvironment _webHostEnvironment;
      
        public CarController(ICarService carService,/* IBookingsService bookingsService,*//* ILocationService locationService,*//* IUserService userService*/ IWebHostEnvironment webHostEnvironment/* ICategoryService categoryService*/)
        {
            this.carService = carService;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var car = carService.GetAll();
            return View(car);

        }
        [HttpGet]
        public IActionResult Create()
        {
          /*  CreateCarViewModel carVM = new CreateCarViewModel
            {
                CategoryList = _categoryService.GetAllCategory().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                }),
                LocationList = _locationService.GetAllLocation().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                })
            };

*/
            return View(/*carVM*/);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateCarViewModel createCarViewModel)
        {
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;
            if (createCarViewModel.Id == 0)
            {
                string upload = webRootPath + WC.ImagePath;
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(files[0].FileName);
                string filePath = fileName + extension;
                using (var fileStream = new FileStream(Path.Combine(upload, filePath), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                createCarViewModel.CarPictureUrl = fileName + extension;
                carService.AddCar(createCarViewModel);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            /*  CreateCarViewModel carVM = new CreateCarViewModel
              {
                  CategoryList = _categoryService.GetAllCategory().Select(c => new SelectListItem
                  {
                      Text = c.Name,
                      Value = c.Id.ToString(),
                  }),
                  LocationList = _locationService.GetAllLocation().Select(c => new SelectListItem
                  {
                      Text = c.Name,
                      Value = c.Id.ToString(),
                  })
              };

  */
            return View(/*carVM*/);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CreateCarViewModel createCarViewModel)
        {
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;
            if (createCarViewModel.Id == 0)
            {
                string upload = webRootPath + WC.ImagePath;
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(files[0].FileName);
                string filePath = fileName + extension;
                using (var fileStream = new FileStream(Path.Combine(upload, filePath), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                createCarViewModel.CarPictureUrl = fileName + extension;
                carService.AddCar(createCarViewModel);
            }
            return RedirectToAction("Index");
        }

        public void Find(int id)
        {
           carService.Find(id);
        }
        public void Delete(int id)
        {
            carService.Delete(id);
        }
    }
}