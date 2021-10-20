using AimsCarRentals.Context;
using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Repositories
{
    public class AdminRepository
    {
        public readonly AimsDbContext _dbContext;
        public AdminRepository(AimsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Admin AddAdmin(Admin admin)
        {
            _dbContext.Admins.Add(admin);
            _dbContext.SaveChanges();
            return admin;
        }


        public Admin FindAdminById(int id)
        {
            return _dbContext.Admins.FirstOrDefault(u => u.Id.Equals(id));
        }
        public void DeleteAdmin(int id)
        {

            var admin = FindAdminById(id);

            if (admin != null)
            {
                _dbContext.Admins.Remove(admin);
                _dbContext.SaveChanges();
            }
        }
        public Admin UpdateAdmins(Admin admin)
        {
            _dbContext.Admins.Update(admin);
            _dbContext.SaveChanges();
            return admin;
        }
        public List<Admin> GetAllAdmin()
        {
            return _dbContext.Admins.ToList();
        }
    }
}
