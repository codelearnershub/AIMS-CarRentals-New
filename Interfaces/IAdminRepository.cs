using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
    public interface IAdminRepository
    {
        public Admin AddAdmin(Admin admin);
        public Admin FindAdminById(int id);
        public void DeleteAdmin(int id);
        public Admin UpdateAdmins(Admin admin);
        public List<Admin> GetAllAdmin();
    }
}
