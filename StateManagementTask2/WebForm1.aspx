<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StateManagementTask2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="UserName" runat="server" ></asp:Label>
            <asp:TextBox runat="server" ID="username" ></asp:TextBox>
            <br />
            <br />
            <asp:Label Text="Password" runat="server" ></asp:Label>
            <asp:TextBox runat="server" ID="password" Type="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" Text="Submit" OnClick="submit"/>
            <asp:Button runat="server" Text="Restore With ViewState" OnClick="Restore_ViewState" />
            <asp:Button runat="server" Text="Restore With Hidden Field" OnClick="Restore_Hiddenfield"/>
            <asp:HiddenField ID="HiddenUser" runat="server" />
            <asp:HiddenField ID="HiddenPass" runat="server" />
        </div>
    </form>
</body>
</html>
