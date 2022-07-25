<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">



<head runat="server">
    <link href="Style%20and%20Script/page1.css" rel="stylesheet" />
    <script src="Style%20and%20Script/pag1.js"></script>
    <title>CALCULATOR</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            <h1>CALCULATOR</h1>
            <asp:Label CssClass="label" runat="server">Number 1</asp:Label>
            <br />
            <input id="x" type="text" runat="server"/>
            <br />
            <asp:Label CssClass="label" runat="server">Number 2</asp:Label>
            <br />
            <input id="y" type="text" runat="server"/>
            <br />
            <br />
            <br />
            <asp:DropDownList CssClass="list" runat="server" ID="Oper">
                <asp:ListItem Value="+">Addition</asp:ListItem>
                <asp:ListItem Value="-">Subtraction</asp:ListItem>
                <asp:ListItem Value="x">Multiplication</asp:ListItem>
                <asp:ListItem Value="/">Division</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button CssClass="button" runat="server" OnClientClick="javascript:return check();" Text="CALCULATE" OnClick="Unnamed_Click" />
        </div>

    </form>
</body>
</html>
