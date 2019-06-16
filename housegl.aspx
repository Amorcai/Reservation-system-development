<%@ Page Language="C#" AutoEventWireup="true" CodeFile="housegl.aspx.cs" Inherits="housegl" %>

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
     <div id="container" style="width:805px">

    <div id="header" style="background-color:#87CEEB;">
<h1 style="margin-bottom:0;">房产信息</h1></div>
    <tr>
         <br />
         点击第一列编号进行预约</tr>
          <div >
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
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelADDRESS" runat="server" Text='<%# Bind("address") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="价格">
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("price") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="类型">
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("type") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" HeaderText="编辑" />
                <asp:TemplateField HeaderText="删除" ShowHeader="False">
                    <FooterTemplate>
                        <asp:Button ID="Button1" runat="server" CommandName="Insert" Text="添加房屋信息" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                            Text="删除"></asp:LinkButton>
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
              </div>

    <p>
        <a href="HomePage.aspx"><input id="Button2" type="button" value="返回主界面" /> </a>
      </p>
         </div>
        <div id="footer" style="color:#778899;clear:both;text-align:center; height: 23px; margin-top: 106px;">房屋预约系统</div>
</body>
</html>
