using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class CarController : Controller
    {
        public readonly ICarService carService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IBranchService _branchService;
        private readonly ICategoryService _categoryService;
        private readonly IBookingsService bookingsService;
        private readonly IUserService userService;
      
        public CarController(IUserService userService ,ICarService carService,IBookingsService bookingsService,IBranchService branchService, IWebHostEnvironment webHostEnvironment, ICategoryService categoryService)
        {

            this.carService = carService;
            _webHostEnvironment = webHostEnvironment;
            _branchService = branchService;
            this.bookingsService = bookingsService;
            _categoryService = categoryService;
            this.userService = userService;
        }
        public IActionResult Index()
        {
            var car = carService.GetAll();
            return View(car);

        }
        [HttpGet]
        public IActionResult Create()
        {
          CreateCarViewModel carVM = new CreateCarViewModel
            {
                CategoryList = _categoryService.GetAllCategories().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                }),
                BranchList = _branchService.GetAll().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                })
            };


            return View(carVM);
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
                carService.AddCar(createCarViewModel,createCarViewModel.BranchId, createCarViewModel.CategoryId);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            UpdateCarViewModel carVM = new UpdateCarViewModel
            {
                CategoryList = _categoryService.GetAllCategories().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                }),
                BranchList = _branchService.GetAll().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                })
            };
            return View(carVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
            public IActionResult Update(UpdateCarViewModel model)
            {
                var files = HttpContext.Request.Form.Files;
                string webRootPath = _webHostEnvironment.WebRootPath;
                if (model.Id == 0)
                {
                    string upload = webRootPath + WC.ImagePath;
                    string fileName = Guid.NewGuid().ToString();
                    string extension = Path.GetExtension(files[0].FileName);
                    string filePath = fileName + extension;
                    using (var fileStream = new FileStream(Path.Combine(upload, filePath), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }
                    model.CarPictureUrl = fileName + extension;
                    carService.UpdateCar(model, model.BranchId, model.CategoryId);
                }
                return RedirectToAction("Index");
            }
       

        public void Find(int id)
        {
           carService.Find(id);
        }
        public IActionResult Delete(int id)
        {
            carService.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var car = carService.Find(id);
            if (car != null)
            {
                return View(car);
            }

            return NotFound();
        }
        [HttpGet]
        [Authorize]
        public IActionResult BookCar()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult BookCar(int id, CreateBookingsViewModel model)
        {

            var car = carService.Find(id);
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var user = userService.FindUserById(userId);
            bookingsService.AddBookings(model,car,user);
            return RedirectToAction("BookingRef");
        }
        [HttpGet]
        public IActionResult SelectCar()
        {
            var car = carService.GetAll();
            return View(car);
        }
        public IActionResult GatAllCarsPerCategory(int categoryId)
        {
            var car = carService.GetAllCarsPerEachBranch(categoryId);
            return View(car);
        }
        public IActionResult GetAllCarsPerEachBranch(int branchId)
        {
            var car = carService.GetAllCarsPerEachBranch(branchId);
            return View(car);
        }
    }
}
