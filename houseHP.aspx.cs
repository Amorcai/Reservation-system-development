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

public partial class housegl : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        string staffname = Session["staffname"].ToString();
       
        if (!this.IsPostBack)
        {
            bind();
        }
    }
    public string getstaffname() { 
        //string staffname = "Amy";
        string staffname = Session["staffname"].ToString();


        return staffname;
    }

    protected void bind()
    {
        House h = new House();
        DataSet ds = h.GetAllHouse();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "Insert":
                GridViewRow gvr = (GridViewRow)(((Button)(e.CommandSource)).Parent.Parent);
                //string ID = ((TextBox)(gvr.FindControl("TextBox1"))).Text;
                string address = ((TextBox)(gvr.FindControl("TextBox3"))).Text;
                string price = ((TextBox)(gvr.FindControl("TextBox4"))).Text;
                string type = ((TextBox)(gvr.FindControl("TextBox5"))).Text;
                House h = new House();
                int id = 0;
               // int.TryParse(ID, out id);
                id = h.gethouseid() + 1;
                h.InsertHouse(id,address,price,type);
                bind();
                break;
        }

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        this.GridView1.EditIndex = e.NewEditIndex;
        bind();

    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        this.GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string ID = ((Label)(this.GridView1.Rows[e.RowIndex].FindControl("Label2"))).Text;
        string address = ((TextBox)(this.GridView1.Rows[e.RowIndex].FindControl("TextBox6"))).Text;
        House h = new House();
        int id = 0;
        int.TryParse(ID, out id);
       h.UpdateHouse(id,address);
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string ID = ((Label)(this.GridView1.Rows[e.RowIndex].FindControl("Label2"))).Text;
        House h = new House();
        int id = 0;
        int.TryParse(ID, out id);
        h.DeleteHouseByCode(id);
        bind();
    }




    
}
