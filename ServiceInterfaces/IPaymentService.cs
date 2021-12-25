using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.ServiceInterfaces
{
    public interface IPaymentService
    {
        public Payment AddPayment(CreatePaymentViewModel model);
        public Payment FindPaymentByBookingRef(string bookingRef);
        public Payment Find(int id);
        public List<PaymentViewModel> GetAll();
 
    }
}
