<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addCLIENT.aspx.cs" Inherits="addCLIENT" %>

<!DOCTYPE html>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>新增顾客</title>
    <style type="text/css">
        #Select1 {
            width: 166px;
        }
        #Button3 {
            width: 200px;
        }
    </style>
</head>
<body>

     <div id="container" style="width:500px">

    <div id="header" style="background-color:#87CEEB;">
<h1 style="margin-bottom:0;">添加客户</h1></div>

    <form id="form1" runat="server">
    <div>
    
  
        <p>
            <asp:Label ID="Label1" runat="server" Text="顾客姓名"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="性别"></asp:Label>
        <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="男" />
        <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="女" />
        <p>
            <asp:Label ID="Label3" runat="server" Text="电话号码"></asp:Label>
        &nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" Width="98px" />
            <asp:Button ID="Button2" runat="server" Text="取消" Width="115px" OnClick="Button2_Click" />
        </p> 

    </div>
    </form>
 

    <p>
       <a href="HomePage.aspx"> <input id="Button3" type="button" value="返回主界面" /></a></p>
 
 </div>
          
</body>
</html>
