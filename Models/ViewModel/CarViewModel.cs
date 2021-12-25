using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models.ViewModel
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string LocationName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string PlateNo { get; set; }
        [Required]
        public int BranchId { get; set; }
        [Required]
        public Branch Branch { get; set; }
        [Required]
        public string SerialNo { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Desription { get; set; }
        [DisplayName("Item Picture URL")]
        [StringLength(1024)]
        public string CarPictureUrl { get; set; }
        public Category Category { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class CreateCarViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Make")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Name")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Plate No")]
        public string PlateNo { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [DisplayName("Branch")]
        public int BranchId { get; set; }
        [Required]
        public Branch Branch { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "choose File")]
        public string CarPictureUrl { get; set; }
        public Category Category { get; set; }
        public IEnumerable<SelectListItem> BranchList { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class UpdateCarViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Make")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Plate No")]
        public string PlateNo { get; set; } 
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [DisplayName("Branch")]
        public int BranchId { get; set; }
        [Required]
        public Branch Branch { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "choose File")]
        public string CarPictureUrl { get; set; }
        public Category Category { get; set; }
        public IEnumerable<SelectListItem> BranchList { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public bool IsAvailable { get; set; }
        public string SerialNo { get; internal set; }
    }
}
