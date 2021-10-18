using AimsCarRentals.Context;
using AimsCarRentals.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Repositories
{
    public class UserRoleRepository
    {

        public readonly AimsDbContext _dbContext;
        public UserRoleRepository(AimsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public UserRole AddUserRole(UserRole userrole)
        {
            _dbContext.UserRoles.Add(userrole);
            _dbContext.SaveChanges();
            return userrole;
        }

        public List<UserRole> FindUserRoles(int userId)
        {
            return _dbContext.UserRoles.Include(r => r.Role).Where(ur => ur.UserId == userId).ToList();
        }
        public List<UserRole> GetAllRoles(int userId)
        {
            return _dbContext.UserRoles.Where(ur => ur.RoleId == userId).ToList();
        }
        public UserRole UpdateUserRole(UserRole userrole)
        {
            _dbContext.UserRoles.Update(userrole);
            _dbContext.SaveChanges();
            return userrole;
        }
    }
}
