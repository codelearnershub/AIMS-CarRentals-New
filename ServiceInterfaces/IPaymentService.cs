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
        public Payment AddPayment(Payment payment);
        public Payment FindPaymentByTransactionRef(string transactionRef);
        public Payment Find(int id);
        public List<PaymentViewModel> GetAll();
        public void VerifyPayment(string reference);


    }
}
