<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CarsWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CarStyleSheet.css" rel="stylesheet" />
    <link href = "https://code.jquery.com/ui/1.10.4/themes/ui-lightness/jquery-ui.css" /
         rel = "stylesheet">
      <script src = "https://code.jquery.com/jquery-1.10.2.js"></script>
      <script src = "https://code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container text-center d-flex pt-5">
         <div class="form-control " >
             <div class="center">
                <label for="input">Enter Car Name</label>
                <input type="text" id="input" class="form-group" />
            </div>
        </div>
            </div>

    </form>




   
    <script>
        const inputCar = document.getElementById("input");
        inputCar.addEventListener("input", () => {
            if (!inputCar.value) {
                BindControls([])
                return
            }
            else {
                $.ajax({
                    url: 'WebForm1.aspx/CarSuggestionList',
                    type: 'post',
                    data: JSON.stringify({ "name": $("#input").val() }),

                    contentType: 'application/json',
                    success: function (data) {
                        BindControls(data.d)
                    }
                });
            }

        })



        function BindControls(list) {

            $('#input').autocomplete({
                source: list,
                minLength: 0,
                scroll: true
            }).focus(function () {
                $(this).autocomplete("search", "");
            });
        }
</script>

</body>
</html>
