using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.NewFolder;
using AimsCarRentals.ServiceInterfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AimsCarRentals.Services
{
    public class PaymentService : IPaymentService
    {
        public readonly IPaymentRepository paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }
        public Payment AddPayment(Payment payment)
        {
           
            return paymentRepository.AddPayment(payment);
        }
        public Payment FindPaymentByTransactionRef(string transactionRef)
        {
            return paymentRepository.FindPaymentByTransactionRef(transactionRef);
        }
       
        public Payment Find(int id)
        {
           return paymentRepository.Find(id);
        }
        public async void VerifyPayment(string reference)
        {
            
            using (var client = new HttpClient())
            {
                var verifyPayment = await client.GetAsync( $"https://api.paystack.co/transaction/verify/{reference}");
                if(verifyPayment.IsSuccessStatusCode )
                {

                    var verification = await verifyPayment.Content.ReadAsStringAsync();
                    var verify = JsonConvert.DeserializeObject<PaymentDto>(verification);
                    
                   if(verify.Status == true && verify.Data.Status == "Success")
                    {
                        var paymentDto = new Payment()
                        {
                            TransactionRef = verify.Data.Reference,
                            AmountPaid = verify.Data.Amount,
                            Email = verify.Customer.Email,
                            PhoneNo = verify.Customer.PhoneNo,
                            CreatedAt = verify.Data.CreatedAt,
                        };
                        
                        paymentRepository.AddPayment(paymentDto);
                    }
                }
             


            }
           
        }
     
        public List<PaymentViewModel> GetAll()
        {
            var category = paymentRepository.GetAll().Select(c => new PaymentViewModel
            {

            }).ToList();
            return category;
        }
    }
}
