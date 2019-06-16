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


public partial class client : System.Web.UI.Page
{
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "Insert":
                GridViewRow gvr = (GridViewRow)(((Button)(e.CommandSource)).Parent.Parent);
                string clientID = ((TextBox)(gvr.FindControl("TextBox1"))).Text;
                string Clientname = ((TextBox)(gvr.FindControl("TextBox3"))).Text;
                string Clientgender = ((TextBox)(gvr.FindControl("TextBox5"))).Text;
                string tel = ((TextBox)(gvr.FindControl("TextBox6"))).Text;
                Client client = new Client();
                int id = 0;
                int.TryParse(clientID, out id);
                client.InsertClient(id,Clientname,Clientgender,tel);
                break;
        }

    }
    
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if ((e.Row.RowState & DataControlRowState.Edit) != 0)
        {
            DropDownList dp1 = (DropDownList)(e.Row.FindControl("DropDownList1"));
        }


    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        DropDownList dp1 = (DropDownList)GridView1.Rows[GridView1.EditIndex].FindControl("DropDownList1");
        
    }
}