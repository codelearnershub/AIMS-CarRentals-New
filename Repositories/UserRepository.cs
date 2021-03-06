using AimsCarRentals.Context;
using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Repositories
{
    public class UserRepository : IUserRepository
    {
        public readonly AimsDbContext _dbContext;
        public UserRepository(AimsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public List<UserRole> FindUserRoles(int userId)
        {
            return _dbContext.UserRoles.Where(ur => ur.UserId == userId).ToList();
        }

        public User FindUserById(int id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id.Equals(id));
        }
        public void DeleteUser(int id)
        {

            var user = FindUserById(id);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
        public User FindUserByEmail(string email)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Email.Equals(email));
        }

        public User UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return user;
        }
        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }



    }
}
