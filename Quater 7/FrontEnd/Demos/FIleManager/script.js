function validate() {
    document.getElementById('fname').style.borderColor = null;
    document.getElementById('lname').style.borderColor = null;
    document.getElementById('address').style.borderColor = null;
    document.getElementById('city').style.borderColor = null;
    document.getElementById('state').style.borderColor = null;
    document.getElementById('zcode').style.borderColor = null;
    document.getElementById('Phone').style.borderColor = null;
    document.getElementById('email').style.borderColor = null;
    document.getElementById('password').style.borderColor = null;
    document.getElementById('vpassword').style.borderColor = null;
    var errors = false;
    var error_msg = "";
    var fName = document.forms['myForm']['fname'].value;
    var lName = document.forms['myForm']['lname'].value;
    var Address = document.forms['myForm']['address'].value;
    var city = document.forms['myForm']['city'].value;
    var State = document.forms['myForm']['state'].value.toUpperCase();
    var zipCode = document.forms['myForm']['zcode'].value;
    var phone = document.forms['myForm']['Phone'].value;
    var Email = document.forms['myForm']['email'].value;
    var password = document.forms['myForm']['password'].value;
    var vPassword = document.forms['myForm']['vpassword'].value;
    var fname_patt = /[a-z]{2,}/i;
    var lname_Patt = /[a-z]{2,}/i;
    var address_Patt = /([a-z]+)\s([a-z]+)/i;
    var city_Patt = /[a-z]{2,}/i;
    var state_Patt = /(A[LKZR]|C[AOT]|DE|FL|GA|HI|I[DLNA]|K[SY]|LA|M[EDAINSOT]|N[EVHJMYCD]|O[HKR]|PA|RI|S[CD]|T[NX]|UT|V[TA]|W[AVIY]){1}/;
    var zcode_Patt_L5 = /^([0-9]{5})/;
    var zcode_Patt_L9 = /^([0-9]{5}\-[0-9]{4})/;
    var phone_patt = /^(1?\([0-9]{3}\)( |)|(1-|1)?[0-9]{3}-?)[0-9]{3}-?[0-9]{4}$/gmi;
    var email_patt = /([\w|\d]+@[\w|\d]{2,}\.[\w|\d]{2,})/;
    var password_Patt = /(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}/;

    function zipFailed() {
        document.getElementById('zcode').style.borderColor = 'red';
        errors = true;
        error_msg += "not a valid Zip Code. A valid zipcode must be at least 8 numbers or 8 numbers, a dash, and 4 more numbers. Example: 12345 or 12345-1234 <br />";

    }

    console.log(zipCode.length);

    if (fname_patt.test(fName) == false) {
        document.getElementById('fname').style.borderColor = 'red';
        errors = true;
        error_msg += "not a valid first name. First name needs at least two letter of the alphabet <br />";
    }
    if (!lname_Patt.test(lName)) {
        document.getElementById('lname').style.borderColor = 'red';
        errors = true;
        error_msg += "not a valid Last name. Last name needs at least two letter of the alphabet <br />";
    }
    if (!address_Patt.test(Address)) {
        document.getElementById('address').style.borderColor = 'red';
        errors = true;
        error_msg += "not a valid address. A valid address must have a least one character, followed by and space and at least one character. Example: My address S 1234 <br />";
    }
    if (!state_Patt.test(State)) {
        document.getElementById('state').style.borderColor = 'red';
        errors = true;
        error_msg += "not a valid State. A valid state code is a US state code of two characters. Example: UT  <br />";
    }
    if (!city_Patt.test(city)) {
        document.getElementById('city').style.borderColor = 'red';
        errors = true;
        error_msg += "not a valid City. A valid city must have at least two character. Example: MyCity . <br />";
    }
    if (zipCode.length == 5) {
        if (!zcode_Patt_L5.test(zipCode)) {
            zipFailed();
        }
    } else if (zipCode.length == 10) {
        if (!zcode_Patt_L9.test(zipCode)) {
            zipFailed();
        }
    } else {
        zipFailed();
    }
    if (!phone_patt.test(phone)) {
        document.getElementById('Phone').style.borderColor = 'red';
        errors = true;
        error_msg += "not a valid phone number. A valid phone number must be in ONE of the following format, 1(801)555-1212, 1(801) 555-1212, (801)555-1212, (801) 555-1212, 801-555-1212, 8015551212. <br />";
    }
    if (!email_patt.test(Email)) {
        document.getElementById('email').style.borderColor = 'red';
        errors = true;
        error_msg += "Invalid Email. A valid email must start with atleast 1 character, followed by the '@' symbol followed by at least 2 characters, followed by '.', and ended with at least 2 characters. Example: MyEmail@email.com <br />";
    }
    if (!password_Patt.test(password)) {
        document.getElementById('password').style.borderColor = 'red';
        errors = true;
        error_msg += "not a valid password. A valid password must be at least 8 characters long and must include at least one capitalized letter, number, and  special character. Example: MyPassword1234$ <br />";

        document.getElementById('vpassword').style.borderColor = 'red';
        error_msg += "Origial password is invalid.";
    }
    if (password_Patt.test(password) && vPassword !== password) {
        document.getElementById('vpassword').style.borderColor = 'red';
        errors = true;
        error_msg += "Passwords do not match";
    }

    if (errors == true) {
        document.getElementById('response').innerHTML = error_msg;
        return false;
    }

}












