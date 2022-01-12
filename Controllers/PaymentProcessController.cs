using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class PaymentProcessController : Controller
    {
        public readonly IPaymentService paymentService;
        public PaymentProcessController( IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }
        /*  [HttpGet]
          public IActionResult Index(string transactionRef)
          {
              //string CurrentUrl = Request.Url.AbsoluteUri;
              var TransactionRef = paymentService.FindPaymentByTransactionRef(transactionRef);
              Console.WriteLine($"This is the transactionRef{TransactionRef}");
              return View();
          }*/
       
        [HttpPost]
        public IActionResult ProcesssPayment(string reference)
        {
            var transactionRef = paymentService.FindPaymentByTransactionRef(reference);
            if (transactionRef != null)
            {
                paymentService.VerifyPayment(transactionRef.TransactionRef);
            }
            
            return View();
        }
    }
}
