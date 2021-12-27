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
        public Payment AddPayment(CreatePaymentViewModel createPaymentViewModel)
        {
            var payment = new Payment
            {
              
            };

            return paymentRepository.AddPayment(payment);
        }
        public Payment FindPaymentByBookingRef(string bookingRef)
        {
            return paymentRepository.FindPaymentByBookingRef(bookingRef);
        }
       
        public Payment Find(int id)
        {
           return paymentRepository.Find(id);
        }

        public async static void VerifyPayment(string transactionRef)
        {
           using (var client = new HttpClient())
            {
                var verifyPayment = await client.GetAsync( $"https://api.paystack.co/transaction/verify/:{transactionRef}");
                if(verifyPayment.IsSuccessStatusCode )
                {
                    var verification = await verifyPayment.Content.ReadAsStringAsync();
                    var verify = JsonConvert.DeserializeObject<PaymentDto>(verification);
                    
                   if(verify.Status == true && verify.Data.Status == "Success")
                    {
                        var paymentDto = new SavePaymentDto()
                        {
                            TransactionRef = verify.Data.Reference,
                            Id = verify.Data.Id,
                        };
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
