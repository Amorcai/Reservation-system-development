<%@ Page Language="C#" AutoEventWireup="true" CodeFile="book.aspx.cs" Inherits="book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="jquery-1.11.3.min.js"></script>
    <script language="javascript" type="text/javascript" src="My97DatePicker/WdatePicker.js"></script> 
<script type="text/javascript">
        $(document).ready(
    function () {
        $("#Button1").click(function () {

            $.get("book.aspx", function (data) {
                $("#count").append(data);
               
            });

        });
    });
    </script>
    <style type="text/css">
        #Button2 {
            width: 139px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div id="count"><button id="Button1">当前预约数</button></div>
        <asp:GridView ID="GridView1" runat="server"  AllowSorting="True" AutoGenerateColumns="False" 
            OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" 
            ShowFooter="True"
            OnRowUpdating="GridView1_RowUpdating" OnRowDataBound="GridView1_RowDataBound" OnSorting="GridView1_Sorting" 
            OnRowCommand="GridView1_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None" Height="247px" Width="920px" OnRowDeleting="GridView1_RowDeleting" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="员工姓名">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("staffname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="顾客姓名">
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="CLIENTNAME" runat="server" Text='<%# Bind("ClientName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="顾客电话">
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("ClientTel") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="预约时间"  SortExpression="bookdata">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("bookdata") %>' onfocus="WdatePicker({dateFmt : 'yyyy-MM-dd HH:mm:ss',minDate:'%y-%M-#{%d+1}'})"></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("bookdata") %>'  onfocus="WdatePicker({dateFmt : 'yyyy-MM-dd HH:mm:ss',minDate:'%y-%M-#{%d+1}'})" ></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("bookdata") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="预约状态" SortExpression="bookstate">
                    <EditItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%#Eval("bookstate") %>' Visible="<%# false %>"></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                            <asp:ListItem Value="001">时间已确认</asp:ListItem>
                            <asp:ListItem Value="002">时间暂定</asp:ListItem>
                            <asp:ListItem Value="003">已取消</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem Value="001">时间已确认</asp:ListItem>
                            <asp:ListItem Value="002">时间暂定</asp:ListItem>
                        </asp:DropDownList>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Getstate(Eval("bookstate").ToString()) %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="更改预约信息" ShowEditButton="True" />
                 
                <asp:TemplateField HeaderText="   ">
                    <FooterTemplate>
                        <asp:Button ID="Button5" runat="server" CommandName="Insert" Text="添加预约记录"/>
                    </FooterTemplate>
                </asp:TemplateField>
                 
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
         <br />
         当前房屋钥匙所在员工姓名：<%= own%>
         <br />
         <br />
         如需要请联系:<%= tel%>
    </form>
    
    <p>
        <a href="HomePage.aspx"><input id="Button2" type="button" value="保存并返回主界面" /><h1>    </h1>
             <a href="key.aspx"><input id="Button3" type="button" value="查看钥匙交接" /> </a>  <a href="addCLIENT.aspx"><input id="Button4" type="button" value="添加新客户" /> </a></p>
              <div id="footer" style="color:#778899;clear:both;text-align:center; height: 23px; margin-top: 106px;">房屋预约系统</div>

</body>
</html>
