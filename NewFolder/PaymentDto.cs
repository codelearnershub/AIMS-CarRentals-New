using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.NewFolder
{
    public class PaymentDto
    {
        public bool Status { get; set; }
        public Data Data { get; set; }
        public Customer Customer { get; set; }
    }
    public class Data 
    {
    public int Id { get; set; }
        public string Domain { get; set; }
        public string Status { get; set; }
        public string Reference { get; set; }
        public double Amount { get; set; }
        public string Message { get; set; }
        public string GateWayResponse { get; set; }
        public DateTime PaidAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Channel { get; set; }
        public string Currency { get; set; }
        public string IpAddress { get; set; }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
    }
    public class SavePaymentDto
    {
      
        public int Id { get; set; }
        public string TransactionRef { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public double AmountPaid { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
