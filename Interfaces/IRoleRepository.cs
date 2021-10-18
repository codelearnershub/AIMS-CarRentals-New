using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
    public interface IRoleRepository
    {
        public Role AddRole(Role role);
        public List<UserRole> FindUserRoles(int userId);
        public void DeleteRole(int id);
        public Role UpdateRole(Role role);
        public List<Role> GetAllRoles();
        public Role FindRoleByName(string name);
        public Role FindRole(int id);
    }
}
