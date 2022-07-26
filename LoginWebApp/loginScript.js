function Validation() {
    console.log("Hello");
    //var user = document.getElementById('username').value;
    //var pass = document.getElementById('password').value;

    if (document.getElementById('username').value == '') { alert("Please Enter Username!"); return false };
    if (document.getElementById('password').value == '') { alert("Please Enter Password!"); return false };
    if (document.getElementById('password').value != "vezli" && document.getElementById('username').value != "polar") { alert("Please Enter Correct Username or Password!"); return false };

    return true;
}