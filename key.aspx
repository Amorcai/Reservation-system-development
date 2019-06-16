<%@ Page Language="C#" AutoEventWireup="true" CodeFile="key.aspx.cs" Inherits="key" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div id="container" style="width:500px">
    <div id="header" style="background-color:#87CEEB;">
<h1 style="margin-bottom:0;">钥匙交接</h1></div>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" >
            <Columns>
                <asp:TemplateField HeaderText="编号">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("HouseID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="钥匙持有者">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Staffname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="钥匙交接者">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("deliver") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="交接时间">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Time") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField EditText="交接" HeaderText="确认交接" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
     <p>
        <a href="HomePage.aspx"><input id="Button2" type="button" value="返回主界面" /> </a></p>
    </div>
       </div>
   

    </form>
            <div id="footer" style="color:#778899;clear:both;text-align:center;">房屋预约系统</div>

</body>
</html>
