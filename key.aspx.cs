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

public partial class key : System.Web.UI.Page
{
    public string staffname;
    protected void Page_Load(object sender, EventArgs e)
    {
        staffname = Session["staffname"].ToString();
        //staffname = "1111";
        if (!this.IsPostBack)
        {
            bind();
        }
    }

    

    protected void bind()
    {
         keylog key = new keylog();
         DataSet ds = key.Getkey(staffname);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        this.GridView1.EditIndex = e.NewEditIndex;
        bind();

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string ID = ((Label)(this.GridView1.Rows[e.RowIndex].FindControl("Label1"))).Text;
        string deliver = ((Label)(this.GridView1.Rows[e.RowIndex].FindControl("Label2"))).Text;
        //string time = ((TextBox)(this.GridView1.Rows[e.RowIndex].FindControl("TextBox1"))).Text;
        System.DateTime currentTime = new System.DateTime();
        currentTime = System.DateTime.Now;
        string systime1 = currentTime.ToString("d");
        keylog key = new keylog();
        int id = 0;
        int.TryParse(ID, out id);
        key.Updatekey(id,staffname,deliver,systime1);
        GridView1.EditIndex = -1;
        Response.Write("<script>alert('钥匙已交接');</script>"); 
        bind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        this.GridView1.EditIndex = -1;
        bind();
    }

    
}