using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
    public interface IUserService
    {
        public void RegisterCustomer(RegisterCustomerViewModel model);
        public User FindUserById(int id);
        public List<RegisterCustomerViewModel> GetAllUser();
        public void Delete(int id);
        public User Login(string email, string password);
        public void UpdateAdmin(UpdateAdminViewModel model);
        public void UpdateCustomer(UpdateCustomerViewModel model);
        public void RegisterAdmin(RegisterAdminViewModel model);
    }
}
