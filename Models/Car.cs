using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models
{
    public class Car:BaseEntity
    { 
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
        public string Description { get; set; }
        [DisplayName("Item Picture URL")]
        [StringLength(1024)]
        public string CarPictureUrl { get; set; }
        public Category Category { get; set; }
        public bool IsAvailable { get; set; }
    }
}
