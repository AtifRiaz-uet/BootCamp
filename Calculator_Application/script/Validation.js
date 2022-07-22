function Validate() {
    let value1 = document.querySelector("#num1").value;
    let value2 = document.querySelector("#num2").value;
    let operation = document.querySelector("#operation").value;

    if (isNaN(value1) == true) { alert("X should be number"); return false; }
    if (isNaN(value2) == true) { alert("Y should be number"); return false; }
    if (value1 === "" || value1 === null) { alert("X is not entered"); return false; };
    if (value2 === "" || value2 === null) { alert("Y is not entered"); return false; };
    if (operation == "/" && value2==0){alert("Undefined error Y is zero"); return false;};

    return true;

}