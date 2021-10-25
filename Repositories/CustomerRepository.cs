using AimsCarRentals.Context;
using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        public readonly AimsDbContext _dbContext;
        public CustomerRepository(AimsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Customer AddUser(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
            return customer;
        }

      
        public Customer FindCustomerById(int id)
        {
            return _dbContext.Customers.FirstOrDefault(u => u.Id.Equals(id));
        }
        public void DeleteCustomer(int id)
        {

            var customer = FindCustomerById(id);

            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
            }
        }
        public Customer UpdateCustomer(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
            return customer;
        }
        public List<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }
    }
}
