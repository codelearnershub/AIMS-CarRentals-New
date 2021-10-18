using AimsCarRentals.Interfaces;
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
        public CarService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }
        public Car AddCar(CreateCarViewModel model)
        {
            var car = new Car
            {
                Name = model.Name,
                PlateNo = model.PlateNo,
                BranchId = model.BranchId,
                CategoryId = model.CategoryId,
                SerialNo = Guid.NewGuid().ToString().Substring(1, 3),
                Price = model.Price,
                CarPictureUrl = model.CarPictureUrl,
                IsAvailable = true,
            };
            return car;
        }
        public Car UpdateCar(UpdateCarViewModel model)
        {
            var car = new Car
            {
                Name = model.Name,
                PlateNo = model.PlateNo,
                BranchId = model.BranchId,
                CategoryId = model.CategoryId,
                Price = model.Price,
                CarPictureUrl = model.CarPictureUrl,
                IsAvailable = true,
                CreatedAt = DateTime.Now,
            };
            return car;
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
                PlateNo = c.PlateNo,
                BranchId = c.BranchId,
                CategoryId = c.CategoryId,
                Price = c.Price,
                CarPictureUrl = c.CarPictureUrl,
                IsAvailable = c.IsAvailable,
                CreatedAt = c.CreatedAt
            }).ToList();
            return car;
          
        }
    }
}
