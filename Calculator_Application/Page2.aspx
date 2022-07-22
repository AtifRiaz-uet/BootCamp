<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Calculator_Application.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="script/Validation.js"></script>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <label class="labels">X = </label>
            <span id="Span1" runat="server"></span><br />

            <label class="labels">Y = </label>
            <span id="Span2" runat="server"></span><br />
            
            <label class="labels">Operation = </label>
            <span id="Span3" runat="server"></span><br />

            <label class="labels">Answer is = </label>
            <span id="Answer_page" runat="server"></span><br />
        </div>
    </form>
</body>
</html>
