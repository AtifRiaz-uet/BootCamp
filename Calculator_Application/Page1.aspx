<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Calculator_Application.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Basic Calculator</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <script src="script/Validation.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" CssClass="labels">X = </asp:Label>
            <input id="num1" type="text" runat="server" /><br />
            <div class="seperation"></div>       

            <asp:Label runat="server" CssClass="labels">Operation =  </asp:Label>
            <asp:DropDownList ID="operation" runat="server">
                <asp:ListItem Value="+">Addition</asp:ListItem>
                <asp:ListItem Value="-">Substraction</asp:ListItem>
                <asp:ListItem Value="x">Multiplication</asp:ListItem>
                <asp:ListItem Value="/">Division</asp:ListItem>
            </asp:DropDownList><br />
            <div class="seperation"></div>

            <asp:Label runat="server" CssClass="labels">Y = </asp:Label>
            <input id="num2" type="text" runat="server" /><br />
            <div class="seperation"></div>

            <asp:Button runat="server" OnClientClick="javascript:return Validate();" Text="Calculate" OnClick="Unnamed_Click" ID="btn_submit"/><br />
            <div class="seperation"></div>

        </div>
    </form>
</body>
</html>
