using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
    public interface ICustomerRepository
    {
        public Customer AddUser(Customer customer);
        public Customer FindCustomerById(int id);
        public void DeleteCustomer(int id);
        public Customer UpdateCustomer(Customer customer);
        public List<Customer> GetAllCustomers();
    }
}
