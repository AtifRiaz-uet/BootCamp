<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GridViewTask2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="GridStyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            <asp:GridView runat="server" ID="EmpData" AllowPaging="true" PageSize="15" OnPageIndexChanging="PageChanging"
                 CellPadding="5" CellSpacing="50" BorderColor="BlueViolet" GridLines="Horizontal" Font-Size="Larger" 
                EnableSortingAndPagingCallbacks="True" AutoGenerateColumns="false" OnRowEditing="EmpData_RowEditing" OnRowDeleting="EmpData_RowDeleting">
                <AlternatingRowStyle BackColor="#F7F7F7" />

                <HeaderStyle Width="25%" />
                <RowStyle Width="25%" />
                <FooterStyle Width="25%" />

                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />

                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />

                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />

                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />

                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />

                <SortedAscendingCellStyle BackColor="#F4F4FD" />

                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />

                <SortedDescendingCellStyle BackColor="#D8D8F0" />

                <SortedDescendingHeaderStyle BackColor="#3E3277" />

                <Columns>
                    <asp:HyperLinkField 
                        DataNavigateUrlFields="Name,Id,Role,Salary" 
                        DataNavigateUrlFormatString="employee.aspx?name={0}&id={1}&role={2}&salary={3}"
                        DataTextField="Name" 
                        HeaderText="NAME" 
                        ItemStyle-Width="40%"
                        ItemStyle-Wrap="true" ItemStyle-Font-Underline="false"
                        />
                    <asp:CommandField HeaderText="Edit" ShowEditButton="true" ItemStyle-Width="15%"/>
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" ItemStyle-Width="15%"/>
                        
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
