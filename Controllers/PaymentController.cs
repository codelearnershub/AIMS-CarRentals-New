/*using Paystack.Net.SDK.Transactions;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.Interfaces;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Configuration;
using Microsoft.AspNetCore.Http;

public async Task InitializePayment(PaymentViewModel model)
{
    string secretKey = ConfigurationManager.AppSettings["PayStackSecretKey"];
    var payStackTransactionAPI = new PaystackTransaction(secretKey);
    var response = await payStackTransactionAPI.InitializeTransaction(model.Email, model.AmountPaid,model.FirstName, model.LastName, "http://loocalhost:17869/order/callback");
    //Note that callback url is optional
    if(response.status == true)
    {
        return Json(new { error = false, result = response }, JsonRequestBehavior.AllowGet);
    }
    return Json(new { error = true, result = response }, JsonRequestBehavior.AllowGet); 
}
[Route("order/callback")]
   public async Task Index()
{
    string secretKey = ConfigurationManager.AppSettings["PaySatckSecret"];
    var payStackTransactionAPI = new PaystackTransaction(secretKey);
    var tranxRef = HttpContext.Request.QueryString["reference"];
    if (tranxRef != null)
    {
        var response = await payStackTransactionAPI.VerifyTransaction(tranxRef);
        if(response.status)
        {
            return response;
        }
    }
     return View("PaymentError");
}*/