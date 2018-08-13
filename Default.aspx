<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
       
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Ekle" />
        
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333"  OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating2" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdated="Page_Load" Width="371px" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" OnRowDeleting="GridView1_RowDeleting1" OnRowDeleted="Page_Load" ShowFooter="True" ShowHeaderWhenEmpty="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CheckBoxField Text="Check Box" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="Name" />
                <asp:BoundField DataField="Country" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        
    </form>
</body>
</html>
