var name = document.getElementById('name').innerText;
var price = document.getElementById('price').innerText;
var amount = parseInt(price)*100;
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
                    value: "+2348012345678" //customer's mobile number
                }
            ]
        },
        callback: function (response) {
            console.log(response)
            //after the transaction have been completed
            //make post call  to the server with to verify payment 
            //using transaction reference as post data
            $.post("verify.php", { reference: response.reference }, function (status) {
                if (status == "success") {
                    console.log(response);
                    //successful transaction
                    alert('Transaction was successful');
                }
                else {
                    alert(response);
                }
                    //transaction failed
                    /*
        console.log(response);*/
    });
            
        },
        onClose: function () {
            //when the user close the payment modal
            alert('Transaction cancelled');
        }
    });
    handler.openIframe(); //open the paystack's payment modal
   
        
}
