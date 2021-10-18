using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Services
{
    public interface IRoleService
    {
        public Role AddRole(CreateRoleViewModel model);
        public Role FindRoleByName(string name);
        public Role UpdateRole(UpdateRoleViewModel model);
        public Role FindRole(int id);
        public void DeleteRole(int id);
        public List<RoleViewModel> GetAllRole();
    }
}
