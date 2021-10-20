using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models.ViewModel
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public List<Role> Roles { get; set; }
        public string HashSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
    }
    public class RegisterCustomerViewModel:LoginViewModel
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

    public class UpdateCustomerViewModel : LoginViewModel
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

