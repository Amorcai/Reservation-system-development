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


public partial class mybook : System.Web.UI.Page
{
    int id = 0;
    string HouseID = "";
    string staffname = "";
    public string own;
    public string tel;

    protected void Page_Load(object sender, EventArgs e)
    {
        staffname = Session["staffname"].ToString();
        Page.Title = "我的预约";
      
        MybookBind(staffname);

        // Response.Write(tel);
        //Response.Write(own);

    }

    protected void MybookBind(string Staffname)
    {
        Book dp = new Book();
        DataView dv = dp.GetMybook(Staffname).Tables[0].DefaultView;
        this.GridView1.DataSource = dv;
        this.GridView1.DataBind();

    }

    protected void bookBind(int HouseID)
    {
        Book dp = new Book();
        DataView dv = dp.Getbook(id).Tables[0].DefaultView;
        string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];
        dv.Sort = sort;
        this.GridView1.DataSource = dv;
        this.GridView1.DataBind();

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //string HouseID = Request.QueryString["HouseID"];
        this.GridView1.EditIndex = e.NewEditIndex;
        // int id = 0;
        // int.TryParse(HouseID, out id);
        bookBind(id);

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string bookdata = ((TextBox)(this.GridView1.Rows[e.RowIndex].FindControl("TextBox3"))).Text;
        string clientname = ((TextBox)(this.GridView1.Rows[e.RowIndex].FindControl("TextBox5"))).Text;
        string bookstate = ((DropDownList)(this.GridView1.Rows[e.RowIndex].FindControl("DropDownList1"))).SelectedValue;
        string staffname = ((Label)(this.GridView1.Rows[e.RowIndex].FindControl("Label1"))).Text;
        Book dp = new Book();
        int clientid = dp.getclientid(clientname);
        // string HouseID = Request.QueryString["HouseID"];
        // int id = 0;
        // int.TryParse(HouseID, out id);
        dp.Updatebook(id, clientid, staffname, bookdata, bookstate);
        GridView1.EditIndex = -1;
        bookBind(id);
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "Insert":
                //Insertbook(int HouseID,int clientID,string staffname,string bookdata,string bookstate)
                GridViewRow gvr = (GridViewRow)(((Button)(e.CommandSource)).Parent.Parent);
                Book book = new Book();
                string bookdata = ((TextBox)(gvr.FindControl("TextBox1"))).Text;
                string bookstate = ((DropDownList)(gvr.FindControl("DropDownList2"))).SelectedValue;
                string clientname = ((TextBox)(gvr.FindControl("TextBox4"))).Text;
                int clientID = book.getclientid(clientname);
                if (clientID > 10000)
                {
                    Response.Write("<script>alert('该顾客尚未登记 请先到顾客表中记录');</script>");
                    break;
                }
                book.Insertbook(id, clientID, staffname, bookdata, bookstate);
                bookBind(id);
                break;
        }
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //string HouseID = Request.QueryString["HouseID"];
        this.GridView1.EditIndex = -1;
        //int id = 0;
        // int.TryParse(HouseID, out id);
        bookBind(id);
    }
    public string Getstate(string state)
    {
        string states = "";
        switch (state)

        {
            case "001":
                states = "时间已确认";
                break;
            case "002":
                states = "时间暂定";
                break;
            case "003":
                states = "已取消";
                break;
        }
        return states;
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if ((e.Row.RowState & DataControlRowState.Edit) != 0)
        {
            DropDownList ddl = (DropDownList)(e.Row.FindControl("DropDownList1"));
            Label label = (Label)(e.Row.FindControl("Label5"));
            for (int i = 0; i < ddl.Items.Count; i++)
            {
                if (ddl.Items[i].Text == label.Text)
                {
                    ddl.SelectedIndex = i;
                    break;
                }
            }
        }
    }
    public string getownname()
    {
        Book book = new Book();
        string name = book.getownname(id);
        return name;
    }
    public string getowntel()
    {
        Book book = new Book();
        string ownname = getownname();
        string tel = book.getowntel(ownname);
        return tel;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string staffname = ((Label)(this.GridView1.Rows[e.RowIndex].FindControl("Label1"))).Text;
        Book book = new Book();
        string clientname = ((Label)(this.GridView1.Rows[e.RowIndex].FindControl("CLIENTNAME"))).Text;
        int clientID = book.getclientid(clientname);
        book.Deletebook(staffname, clientID);
        bookBind(id);
    }
    protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
    {
        string sPage = e.SortExpression;
        if (ViewState["SortOrder"].ToString() == sPage)
        {
            if (ViewState["OrderDire"].ToString() == "Desc")
                ViewState["OrderDire"] = "ASC";
            else
                ViewState["OrderDire"] = "Desc";
        }
        else
        {
            ViewState["SortOrder"] = e.SortExpression;
        }
        bookBind(id);
    }
}