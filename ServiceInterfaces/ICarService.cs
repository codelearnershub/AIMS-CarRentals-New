using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.ServiceInterfaces
{
    public interface ICarService
    {
        public Car AddCar(CreateCarViewModel model,int branchId,int categoryId);
        public Car UpdateCar(UpdateCarViewModel model,int branchId,int categoryId);
        public Car Find(int id);
        public Car Delete(int id);
        public List<CarViewModel> GetAll();
        public List<Car> GetCarsPerEachCategory(int categoryId);
        public List<Car> GetAllCarsPerEachBranch(int branchId);
        public Car UpdateIsAvailable(Car car);
    }
}
