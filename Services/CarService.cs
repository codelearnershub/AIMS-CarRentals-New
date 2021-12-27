﻿using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.Repositories;
using AimsCarRentals.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Services
{
    public class CarService:ICarService
    {
        public readonly ICarRepository carRepository;
        public readonly IBranchService _branchService;
        public readonly ICategoryService _categoryService;
        public CarService(ICarRepository carRepository,IBranchService branchService,ICategoryService categoryService)
        {
            _branchService = branchService;
            this.carRepository = carRepository;
            _categoryService = categoryService;
        }
        public Car AddCar(CreateCarViewModel model,int branchId, int categoryId)
        {
            var car = new Car
            {
                Name = model.Name,
                Make = model.Make,
                PlateNo = model.PlateNo,
                BranchId = model.BranchId,
                CategoryId = model.CategoryId,
                SerialNo = Guid.NewGuid().ToString().Substring(1,3).ToUpper(),
                Price = model.Price,
                CarPictureUrl = model.CarPictureUrl,
                Branch = _branchService.Find(branchId),
                Category = _categoryService.FindCategory(categoryId),
                IsAvailable = true,
                Description = model.Description
            };
            return carRepository.AddCar(car);
        }
        public Car UpdateCar(UpdateCarViewModel model, int branchId,int categoryId,int id)
        {
             var car = carRepository.Find(id);
             if (car != null)
             {
                car.Name = model.Name;
                car.Make = model.Make;
                car.PlateNo = model.PlateNo;
                car.BranchId = model.BranchId;
                car.CategoryId = model.CategoryId;
                car.SerialNo = Guid.NewGuid().ToString().Substring(1, 3).ToUpper();
                car.Price = model.Price;
                car.CarPictureUrl = model.CarPictureUrl;
                car.Branch = _branchService.Find(branchId);
                car.Category = _categoryService.FindCategory(categoryId);
                car.IsAvailable = model.IsAvailable;
                car.Description = model.Description;
                return carRepository.UpdateCar(car);
            }
            return null;
        }
      
            public Car UpdateIsAvailable(Car car)
            {
                Car newCar = new Car
                {
                    IsAvailable = car.IsAvailable,
                    SerialNo = car.SerialNo,
                };
                return carRepository.UpdateCar(newCar);
            }
      
        
        public Car Delete(int id)
        {
          return  carRepository.Delete(id);
        }
        public Car Find(int id)
        {
            return carRepository.Find(id);
        }
        public List<CarViewModel> GetAll()
        {
            var car = carRepository.GetAll().Select(c => new CarViewModel
            { 
                Id = c.Id,
                Name = c.Name,
                Make = c.Make,
                PlateNo = c.PlateNo,
                BranchId = c.BranchId,
                CategoryId = c.CategoryId,
                SerialNo = c.SerialNo,
                Price = c.Price,
                IsAvailable = c.IsAvailable,
                CarPictureUrl = c.CarPictureUrl,
                Branch = _branchService.Find(c.BranchId),
                Category = _categoryService.FindCategory(c.CategoryId),
            }).ToList();
            return car;
        }
        public List<Car> GetCarsPerEachCategory(int categoryId)
        {
            return carRepository.GetCarsPerEachCategory(categoryId);
        }
        public List<Car> GetAllCarsPerEachBranch(int branchId)
        {
            return carRepository.GetAllCarsPerEachBranch(branchId);
        }
        public List<CarViewModel> GetAllBookedCars()
        {
            return carRepository.GetAllBookedCars().Select(c => new CarViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Make = c.Make,
                PlateNo = c.PlateNo,
                BranchId = c.BranchId,
                CategoryId = c.CategoryId,
                SerialNo = c.SerialNo,
                Price = c.Price,
                IsAvailable = c.IsAvailable,
                CarPictureUrl = c.CarPictureUrl,
                Branch = _branchService.Find(c.BranchId),
                Category = _categoryService.FindCategory(c.CategoryId),
            }).ToList(); ;
        }
        public List<CarViewModel> GetAllUnBookedCars()
        {
            return carRepository.GetAllUnBookedCars().Select(c => new CarViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Make = c.Make,
                PlateNo = c.PlateNo,
                BranchId = c.BranchId,
                CategoryId = c.CategoryId,
                SerialNo = c.SerialNo,
                Price = c.Price,
                IsAvailable = c.IsAvailable,
                CarPictureUrl = c.CarPictureUrl,
                Branch = _branchService.Find(c.BranchId),
                Category = _categoryService.FindCategory(c.CategoryId),
            }).ToList(); ;
        }
    }
}
