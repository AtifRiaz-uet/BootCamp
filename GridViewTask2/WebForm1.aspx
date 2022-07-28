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
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <asp:Button Text="Search" runat="server" OnClick="Search_Click"/>
            <hr />
            <asp:GridView runat="server" ID="EmpData" AllowPaging="true" PageSize="15" OnPageIndexChanging="EmpData_PageIndexChanging"
                 CellPadding="5" CellSpacing="50" BorderColor="BlueViolet" GridLines="Horizontal" Font-Size="Larger" 
                 AutoGenerateColumns="false" OnRowEditing="EmpData_RowEditing" OnRowDeleting="EmpData_RowDeleting" OnRowUpdating="EmpData_RowUpdating"
                 OnRowCancelingEdit="EmpData_RowCancelingEdit">
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
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Id") %>' ID="id_txt" ></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>  
                            <asp:TextBox ID="txt_Id" runat="server" Text='<%#Eval("Id") %>'></asp:TextBox>  
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Name") %>' ID="name_txt" ></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>  
                            <asp:TextBox ID="txt_Name" runat="server" Text='<%#Eval("Name") %>'></asp:TextBox>  
                        </EditItemTemplate> 
                    </asp:TemplateField>

                    <asp:HyperLinkField 
                        DataNavigateUrlFields="Name,Id,Role,Salary" 
                        DataNavigateUrlFormatString="employee.aspx?name={0}&id={1}&role={2}&salary={3}"
                        Text="Select"
                        HeaderText="Selection" 
                        ItemStyle-Width="15%"
                        ItemStyle-Wrap="true" ItemStyle-Font-Underline="false"
                        />
                    <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update"/>  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel"/>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                        
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
