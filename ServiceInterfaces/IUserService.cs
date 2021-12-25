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
        public void RegisterAdmin(RegisterAdminViewModel model);
        public User FindUserById(int id);
        public User Login(string email, string password);
        public List<UserViewModel> GetAllUser();
        public void Delete(int id);
        public User UpdateAdmin(int id, UpdateAdminViewModel model);
        public User UpdateCustomer(UpdateCustomerViewModel model,int id);
        public List<CustomerViewModel> GetAllCustomers();
        public List<AdminViewModel> GetAllAdmins();
    }
}
