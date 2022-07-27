<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="GridViewTask2.employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="GridStyleSheet.css" rel="stylesheet" />
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            Name: <asp:Label runat="server" ID="name"></asp:Label>
            <br />
            ID: <asp:Label runat="server" ID="id"></asp:Label>
            <br />
            Role: <asp:Label runat="server" ID="role"></asp:Label>
            <br />
            Salary: <asp:Label runat="server" ID="salary"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
