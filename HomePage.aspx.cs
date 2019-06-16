using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
       string staffname = Session["staffname"].ToString();
       Response.Write("欢迎你"+ staffname);
    }
    public string getstaffname()
    {
        //string staffname = "Amy";
        string staffname = Session["staffname"].ToString();


        return staffname;
    }
}