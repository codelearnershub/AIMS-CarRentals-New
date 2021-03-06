using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models.ViewModel
{
    public class AdminViewModel
    {
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
    }
    public class RegisterAdminViewModel : LoginViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Register As")]
        public int UserType { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        public List<Role> Roles { get; set; }
        public string HashSalt { get; set; }
        public string PasswordHash { get; set; }
    }
    public class UpdateAdminViewModel : LoginViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        public List<Role> Roles { get; set; }
        public string HashSalt { get; set; }
        public string PasswordHash { get; set; }
    }
}

