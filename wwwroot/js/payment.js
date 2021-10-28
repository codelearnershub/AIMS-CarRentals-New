var customerEmail = document.getElementById.innerText();

function payWithPaystack() {
    var handler = PaystackPop({
        key: 'owners_public_key',// owners public key
        email: 'customerEmail',// customer's email
        amount: 'customerEmail', //amount the customer to be paid
        metadata: {
            custom_fields: [
                {
                    display_name: '',
                    variable_name: '',
                    value: "customerEmail" // customer's phone number
                }
            ]
        },

        callback: function (response) {
            //after the transaction has been completed
            alert('success. transaction ref is ' + response);// transaction
        },
        onclose: function () {
            // when the user closes the payment modal
            alert('Transaction cancelled');
        }
    });
  handler.openIframe(); // opens the paystack's payment modal


}