<%@ Page Language="C#" AutoEventWireup="true" CodeFile="houseHP.aspx.cs" Inherits="housegl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>房屋信息</title>
    <style type="text/css">
        #Button2 {
            width: 131px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="280px" Width="807px" 
            OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowCommand="GridView1_RowCommand" 
            ShowFooter="True" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" 
            OnRowUpdating="GridView1_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="编号">
                    <ItemTemplate>
                        <a href='book.aspx?HouseID=<%# Eval("HouseID").ToString() %>&staffname=<%#getstaffname().ToString() %>'><asp:Label ID="Label2" runat="server" Text='<%# Bind("HouseID") %>'></asp:Label></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="地址">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("address") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelADDRESS" runat="server" Text='<%# Bind("address") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="价格">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("price") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="类型">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("type") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle  HorizontalAlign="Center" BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle HorizontalAlign="Center" BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle  HorizontalAlign="Center" BackColor="#6D95E1" />
            <SortedDescendingCellStyle  HorizontalAlign="Center" BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle HorizontalAlign="Center" BackColor="#4870BE" />
        </asp:GridView>
    </form>
</body>
</html>
