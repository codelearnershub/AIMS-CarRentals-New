using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
    public interface IUserRepository
    {
        public User AddUser(User user);
        public List<UserRole> FindUserRoles(int userId);
        public User FindUserById(int id);
        public void DeleteUser(int id);
        public User FindUserByEmail(string email);
        public User UpdateUser(User user);
        public List<User> GetAllUsers();
    }
}
