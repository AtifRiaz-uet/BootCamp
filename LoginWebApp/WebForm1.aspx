<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LoginWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <link href="LoginStyleSheet.css" rel="stylesheet" />
    <script src="loginScript.js"></script>
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            <asp:Label Text="UserName" runat="server" ></asp:Label>
            <asp:TextBox runat="server" ID="username" ></asp:TextBox>
            <br />
            <br />
            <asp:Label Text="Password" runat="server" ></asp:Label>
            <asp:TextBox runat="server" ID="password" Type="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" Text="Login"  ID="button" OnClientClick="javascript:return Validation()" OnClick="login_page"/>
        </div>
    </form>
</body>
</html>
