using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Services
{
    public class RoleService : IRoleService
    {
        public readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public Role AddRole(CreateRoleViewModel model)
        {
            var role = new Role
            {
                Id = model.Id,
                Name = model.Name,
                CreatedAt = DateTime.Now
            };

            return _roleRepository.AddRole(role);
        }
        public Role FindRoleByName(string name)
        {
            return _roleRepository.FindRoleByName(name);
        }
        public Role UpdateRole(UpdateRoleViewModel model)
        {
            var role = new Role
            {
                Id = model.Id,
                Name = model.Name
            };
            return _roleRepository.UpdateRole(role);
        }
        public Role FindRole(int id)
        {
           return _roleRepository.FindRole(id);
        }

        public void DeleteRole(int id)
        {
            _roleRepository.DeleteRole(id);
        }
        public List<RoleViewModel> GetAllRole()
        {
            var category = _roleRepository.GetAllRoles().Select(c => new RoleViewModel
            {
                Id = c.Id,
                Name = c.Name,
                CreatedAt = DateTime.Now

            }).ToList();
            return category;
        }
    }
}
