using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models
{
    public class User:BaseEntity
    {
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string HashSalt { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string PhoneNo { get; set; }

        public string Address { get; set; }
        [Required]
        public string Gender { get; set; }
        public string UserType { get; set; }
    }
}
