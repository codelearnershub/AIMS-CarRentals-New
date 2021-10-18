using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Compare(("Password"), ErrorMessage = "Confirm Password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
