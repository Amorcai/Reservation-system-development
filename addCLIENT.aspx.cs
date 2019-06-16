using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


public partial class addCLIENT : System.Web.UI.Page
{
    string gender;
    Client client = new Client();
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        gender = "男";

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Client client = new Client();
        Session["name"] = TextBox1.Text;
        Session["tel"] = TextBox2.Text;
        string name = Session["name"].ToString();
        string tel = Session["tel"].ToString();
        id=client.getid()+1;
        client.InsertClient(id,name,gender,tel);
        string scriptString = "alert(" + "'添加成功'" + ");";
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "warning", scriptString, true);
    

       
   
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        gender = "女";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";

    }
}