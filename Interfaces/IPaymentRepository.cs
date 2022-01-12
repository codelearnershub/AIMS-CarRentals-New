using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
   public interface IPaymentRepository
    {       
            public Payment AddPayment(Payment payment);
            public Payment Find(int id);
            public Payment Delete(int id);
            public List<Payment> GetAll();
        /* public List<Bookings> BookingHistory(int userId)
         {
             return aimsDbContext.Bookings.Where(c => c.UserId == userId).Include(c => c.User).ToList();
         } */
        public Payment FindPaymentByTransactionRef(string transactioRef);
    }
    


}

