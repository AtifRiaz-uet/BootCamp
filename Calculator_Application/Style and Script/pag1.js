function check() {
    console.log("Hello World")
    var num1 = document.getElementById("x").value;
    var num2 = document.getElementById("y").value;
    var oper = document.getElementById("Oper").value;

    if (isNaN(num1) == true) { alert("Number 1 Should be a Number!"); return false };
    if (isNaN(num2) == true) { alert("Number 2 Should be a Number!"); return false };
    if (num1 === "" || num1 === null) { alert("Number 1 is not entered"); return false };
    if (num2 === "" || num2 === null) { alert("Number 2 is not entered"); return false };
    if (oper === "/" && num2 === "0") { alert("Answer is Undefine"); return false };


    return true;
}