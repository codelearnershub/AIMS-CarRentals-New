using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Models.ViewModel
{
	public class BookingsViewModel
	{
		public int Id { get; set; }
		public string Booking_ref { get; set; }
		public User User { get; set; }
		public int UserId { get; set; }
		public int BranchId { get; set; }
		public Branch Branch { get; set; }
		public int CarId { get; set; }
		public Car Car { get; set; }
		public DateTime PickUpDate { get; set; }
		public DateTime ReturnDate { get; set; }
		public DateTime CreatedAt { get; set; }
        public User UserName { get; internal set; }
        public Car CarName { get; internal set; }
    }
	public class CreateBookingsViewModel

	{
		public Car Car { get; set; }
		public int CarId { get; set; }
		public User User { get; set; }
		public int UserId { get; set; }
		public int Id { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Booking ref No")]
		public string Booking_ref { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Return Date")]
		public DateTime ReturnDate { get; set; }
		public DateTime CreatedAt { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "PickUp Date")]
		public DateTime PickUpDate { get; set; }
    }
	public class UpdateBookingsViewModel
	{

		public Car Car { get; set; }
		public User User { get; set; }
		public int Id { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Booking ref No")]
		public string Booking_ref { get; set; }

		public int UserId { get; set; }

		public int CarId { get; set; }

		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "PickUp Date")]
		public DateTime PickUpDate { get; set; }

		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Return Date")]
		public DateTime ReturnDate { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
