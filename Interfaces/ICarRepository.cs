using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
   public interface ICarRepository
    {
        public Car AddCar(Car car);
        public Car UpdateCar(Car car);
        public Car Find(int id);
        public Car Delete(int id);
        public List<Car> GetAll();
        public List<Car> GetCarsPerEachCategory(int categoryId);
        public List<Car> GetAllCarsPerEachBranch(int branchId);
        public List<Car> GetAllBookedCars();
        public List<Car> GetAllUnBookedCars();
    }
}
