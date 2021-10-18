using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models.ViewModel
{
    public class BranchViewModel
    {
       
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public DateTime CreatedAt { get; set; }
    }
        public class CreateBranchViewModel
        {
            [Required(ErrorMessage = "Fill out this field")]
            [Display(Name = "Name")]
            public string Name { get; set; }
            [Required(ErrorMessage = "Fill out this field")]
            [Display(Name = "Address")]
            public string Address { get; set; }
            public int Id { get; set; }

        }
        public class UpdateBranchViewModel
        {
            [Required(ErrorMessage = "Fill out this field")]
            [Display(Name = "Name")]
            public string Name { get; set; }
            [Required(ErrorMessage = "Fill out this field")]
            [Display(Name = "Address")]
            public string Address { get; set; }
            public int Id { get; set; }
        }

    }

