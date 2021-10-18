using AimsCarRentals.Context;
using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Repositories
{
    public class RoleRepository:IRoleRepository
    {
        public readonly AimsDbContext _dbContext;
     
        public RoleRepository(AimsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Role FindRoleByName(string name)
        {
            return _dbContext.Roles.FirstOrDefault(v => v.Name.Equals(name));
        }
        public Role AddRole(Role role)
        {
            _dbContext.Roles.Add(role);
            _dbContext.SaveChanges();
            return role;
        }

        public List<UserRole> FindUserRoles(int userId)
        {
            return _dbContext.UserRoles.Where(ur => ur.UserId == userId).ToList();
        }


        public void DeleteRole(int id)
        {

            var role = FindRole(id);

            if (role != null)
            {
                _dbContext.Roles.Remove(role);
                _dbContext.SaveChanges();
            }
        }

        public Role UpdateRole(Role role)
        {
            _dbContext.Roles.Update(role);
            _dbContext.SaveChanges();
            return role;
        }
        public Role FindRole(int id)
        {
            return _dbContext.Roles.Find(id);
        }
        public List<Role> GetAllRoles()
        {
            return _dbContext.Roles.ToList();
        }
    }
}
