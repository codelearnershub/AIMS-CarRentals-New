﻿var name = document.getElementById('email').innerText;
var price = document.getElementById('pryce').innerText;
var amount = parseInt(price) * 100;
var PhoneNo = document.getElementById('PhoneNo').innerText;
function payWithPaystack() {


    var handler = PaystackPop.setup({
        key: 'pk_test_ea4c9b4f0591ec661174704f63adaadf2b2a2423', //put your public key here
        email: name, //put your customer's email here
        amount: amount, //amount the customer is supposed to pay
        metadata: {
            custom_fields: [
                {
                    display_name: "Mobile Number",
                    variable_name: "mobile_number",
                    value: "PhoneNo" //customer's mobile number
                }
            ]
        },
        callback: function (response) {
            var reference = response.reference;
            console.log(response)
            alert('Payment complete! Reference: ' + reference);
            //after the transaction have been completed
            //make post call  to the server with to verify payment 
            //using transaction reference as post data
            $.ajax(
                {
                    url: "https://localhost:44357/PaymentProcess/" + reference,
                    method: 'get',
                    success: function (response) {
                        alert('Transaction was successful')
                    }

                }
            );

        },
        onClose: function () {
            //when the user close the payment modal
            alert('Transaction cancelled');
        }
    });
    handler.openIframe(); //open the paystack's payment modal


}