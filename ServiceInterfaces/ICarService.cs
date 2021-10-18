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
        public Car AddCar(CreateCarViewModel model);
        public Car UpdateCar(UpdateCarViewModel model);
        public Car Find(int id);
        public Car Delete(int id);
        public List<CarViewModel> GetAll();

    }
}
