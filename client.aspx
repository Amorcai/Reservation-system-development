<%@ Page Language="C#" AutoEventWireup="true" CodeFile="client.aspx.cs" Inherits="client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>顾客信息</title>
     <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,700' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="css/normalize.css">




    <style>
        /* NOTE: The styles were added inline because Prefixfree needs access to your styles and they must be inlined if they are on local disk! */
        body {
            font-family: "Open Sans", sans-serif;
            height: 100vh;
            background: url("http://i.imgur.com/HgflTDf.jpg") 50% fixed;
            background-size: cover;
        }

        @keyframes spinner {
            0% {
                transform: rotateZ(0deg);
            }

            100% {
                transform: rotateZ(359deg);
            }
        }

        * {
            box-sizing: border-box;
        }


         

        tb {
          
            text-align: center;
          
        }

            footer a, footer a:link {
                color: #fff;
                text-decoration: none;
            }
    </style>

    <script src="js/prefixfree.min.js"></script>
</head>
<body>
     <div id="container" style="width:616px">

    <div id="header" style="background-color:#87CEEB;">
<h1 style="margin-bottom:0;">所有客户信息</h1></div>
          <div>
    <form id="form1" runat="server" class="tb">
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:houseConnectionString %>"
            SelectCommand="select ClientID as 顾客编号,ClientName as 姓名,ClientGender as 性别,ClientTel as 电话号码 from client" DeleteCommand="delete from client where ClientID=@顾客编号" UpdateCommand="update client set ClientID=@顾客编号,ClientName=@姓名,ClientGender=@性别,ClientTel=@电话号码 where ClientID=@顾客编号" ProviderName="<%$ ConnectionStrings:houseConnectionString.ProviderName %>">
            <DeleteParameters>
                <asp:ControlParameter ControlID="GridView1" Name="顾客编号" PropertyName="SelectedValue" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="顾客编号" />
                <asp:Parameter Name="姓名" />
                <asp:Parameter Name="性别" />
                <asp:Parameter Name="电话号码" />
            </UpdateParameters>
        </asp:SqlDataSource>

   
   
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" 
            Height="256px" Width="608px" AllowPaging="True" AllowSorting="True" 
            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" 
            DataKeyNames="顾客编号" OnRowDataBound="GridView1_RowDataBound" OnRowUpdating="GridView1_RowUpdating" 
            style="margin-left: 7px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="顾客编号" HeaderText="顾客编号"  ReadOnly="True" SortExpression="顾客编号" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                <asp:BoundField DataField="性别" HeaderText="性别" SortExpression="性别" />
                <asp:BoundField DataField="电话号码" HeaderText="电话号码" SortExpression="电话号码" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                   
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333"   />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
                  </div>
     <p>
        <a href="HomePage.aspx"><input id="Button2" type="button" value="返回主界面" /> </a></p>
         </div>
            <div id="footer" style="color:#778899;clear:both;text-align:center; height: 23px; margin-top: 106px;">房屋预约系统</div>

</body>
</html>
