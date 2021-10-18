using AimsCarRentals.Context;
using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Repositories
{
    public class CarRepository:ICarRepository
    {
        public readonly AimsDbContext aimsDbContext;
        public CarRepository(AimsDbContext aimsDbContext)
        {
            this.aimsDbContext = aimsDbContext;
        }
        public Car AddCar(Car car)
        {
            aimsDbContext.Cars.Add(car);
            aimsDbContext.SaveChanges();
            return car;
        }
        public Car UpdateCar(Car car)
        {
            aimsDbContext.Cars.Update(car);
            aimsDbContext.SaveChanges();
            return car;
        }
        public Car Find(int id)
        {
            return aimsDbContext.Cars.Find(id);
        }
        public Car Delete(int id)
        {
            var car = Find(id);
            if (car != null)
            {
                aimsDbContext.Cars.Remove(car);
                aimsDbContext.SaveChanges();
            }
            return null;
        }
        public List<Car> GetAll()
        {
           return aimsDbContext.Cars.ToList();
        }
    }
}
