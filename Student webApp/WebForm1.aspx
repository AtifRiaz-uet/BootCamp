<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Student_webApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="studentstyle.css" rel="stylesheet" />
    <title>Student Data</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        function getData()
        {
            var std = document.getElementById("dropList").value;
            $.ajax(
                {
                    url: 'WebForm1.aspx/GetStudentInfo',
                    type: 'post',
                    data: JSON.stringify({ "rollNo": std }),
                    contentType: 'application/json',
                    async: true,
                    success: function (data)
                    {
                        console.log(data.d);
                        var info = data.d;
                        console.log(info);
                        document.getElementById("span1").innerHTML = info.Name;
                        document.getElementById("span2").innerHTML = info.IDnum;
                        document.getElementById("span3").innerHTML = info.age;
                    }
                });
            return false;

        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            <asp:DropDownList ID="dropList" runat="server" ></asp:DropDownList>
            <br />
            <br />
            <input type="button" id="button" value="Data" onclick="getData()"/>
            <br />
            <br />
            <br />

            <span id="span1"></span>
            <span id="span2"></span>
            <span id="span3"></span>
        </div>
    </form>
</body>
</html>
