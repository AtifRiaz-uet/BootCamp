﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewState_WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" id="txt" EnableViewState="true"></asp:TextBox>
            <asp:Button Text="Increase me!" runat="server" OnClick="Unnamed_Click"/>
        </div>
    </form>
</body>
</html>
