<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stdgrid.aspx.cs" Inherits="GridView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="GridViewStyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            <asp:GridView runat="server" ID="StdGrid" HeaderStyle-BackColor="Tomato" BorderColor="MidnightBlue" ></asp:GridView>
        </div>
    </form>
</body>
</html>
