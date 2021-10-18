using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
   public interface IUserRoleRepository
    {
        public UserRole AddUserRole(UserRole userrole);
        public List<UserRole> FindUserRoles(int userId);
        public List<UserRole> GetAllRoles(int userId);
        public UserRole UpdateUserRole(UserRole userrole);
    }
}
