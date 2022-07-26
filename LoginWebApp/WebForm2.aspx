<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="LoginWebApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="LoginStyleSheet.css" rel="stylesheet" />
    <title>Session</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            Hello <asp:Label ID="user" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button runat="server" Text="Logout" ID="button" OnClick="logout"/>

        </div>
    </form>
</body>
</html>
