using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AimsCarRentals.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        public UserService(IUserRepository userRepository, IRoleRepository roleRepository, IUserRoleRepository userRoleRepository)
        {
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _roleRepository = roleRepository;
        }

        private string HashPassword(string password, string salt)
        {
            byte[] saltByte = Convert.FromBase64String(salt);
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltByte,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
        public void RegisterCustomer(RegisterCustomerViewModel model)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(model.Password, saltString);

            var role = _roleRepository.FindRoleByName("Customer");
            if (role != null)
            {
                User user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    MiddleName = model.MiddleName,
                    Email = model.Email,
                    Gender = model.Gender,
                    PasswordHash = hashedPassword,
                    HashSalt = saltString,
                    PhoneNo = model.PhoneNo,
                    DateOfBirth = model.DateOfBirth,
                    Address = model.Address,

                };
                var userRole = new UserRole
                {
                    UserId = user.Id,
                    RoleId = role.Id,
                };
                user.UserRoles.Add(userRole);
                _userRepository.AddUser(user);
            }
            else
            {
                throw new Exception("No Role found");
            }
        }
        public void RegisterAdmin(RegisterAdminViewModel model)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(model.Password, saltString);

            var role = _roleRepository.FindRoleByName("Admin");
            if (role != null)
            {
                User user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    MiddleName = model.MiddleName,
                    Email = model.Email,
                    Gender = model.Gender,
                    PasswordHash = hashedPassword,
                    HashSalt = saltString,
                    PhoneNo = model.PhoneNo,
                    DateOfBirth = model.DateOfBirth,
                    Address = model.Address,

                };
                var userRole = new UserRole
                {
                    UserId = user.Id,
                    RoleId = role.Id,
                };
                user.UserRoles.Add(userRole);
                _userRepository.AddUser(user);
            }
            else
            {
                throw new Exception("No Role found");
            }
        }
        public User FindUserById(int id)
        {
            return _userRepository.FindUserById(id);
        }

        public User Login(string email, string password)
        {
            User user = _userRepository.FindUserByEmail(email);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return null;
            }

            string HashedPassword = HashPassword(password, user.HashSalt);

            if (user.PasswordHash.Equals(HashedPassword))
            {
                Console.WriteLine("User is found");

                return user;
            }
            return null;

        }
        public List<UserViewModel> GetAllUser()
        {
            var user = _userRepository.GetAllUsers().Select(c => new UserViewModel
            { 
                Id = c.Id,
                FirstName = c.FirstName,
                MiddleName = c.MiddleName,
                LastName = c.LastName,
                Gender = c.Gender,
                DateOfBirth = c.DateOfBirth,
                PhoneNo = c.PhoneNo,
                Email = c.Email,
                Address = c.Address,
                PasswordHash = c.PasswordHash,
                HashSalt = c.HashSalt,
                CreatedAt = c.CreatedAt
            }).ToList();
            return user;
        }
        public void Delete(int id)
        {
            _userRepository.DeleteUser(id);
        }
        public void UpdateAdmin(UpdateAdminViewModel model)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(model.Password, saltString);

            var role = _roleRepository.FindRoleByName("Admin");
            if (role != null)
            {
                User user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    MiddleName = model.MiddleName,
                    Email = model.Email,
                    Gender = model.Gender,
                    PasswordHash = hashedPassword,
                    HashSalt = saltString,
                    PhoneNo = model.PhoneNo,
                    DateOfBirth = model.DateOfBirth,
                    Address = model.Address,

                };
                var userRole = new UserRole
                {
                    UserId = user.Id,
                    RoleId = role.Id,
                };
                user.UserRoles.Add(userRole);
                _userRepository.UpdateUser(user);
            }
            else
            {
                throw new Exception("No Role found");
            }


        }
        public void UpdateCustomer(UpdateCustomerViewModel model)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(model.Password, saltString);

            var role = _roleRepository.FindRoleByName("Admin");
            if (role != null)
            {
                User user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    MiddleName = model.MiddleName,
                    Email = model.Email,
                    Gender = model.Gender,
                    PasswordHash = hashedPassword,
                    HashSalt = saltString,
                    PhoneNo = model.PhoneNo,
                    DateOfBirth = model.DateOfBirth,
                    Address = model.Address,

                };
                var userRole = new UserRole
                {
                    UserId = user.Id,
                    RoleId = role.Id,
                };
                user.UserRoles.Add(userRole);
                _userRepository.UpdateUser(user);
            }
            else
            {
                
            }

        }

    }
}