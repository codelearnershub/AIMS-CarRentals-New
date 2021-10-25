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
        public User LoginUser(string email, string password);
        public List<UserViewModel> GetAllUser();
        public void Delete(int id);
        public User UpdateAdmin(UpdateAdminViewModel model);

    }
}
