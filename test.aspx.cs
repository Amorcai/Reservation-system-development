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
using System.Data.SqlClient;

public partial class test : System.Web.UI.Page
{
    Staff s = new Staff();
    protected void Page_Load(object sender, EventArgs e)
    {
            if (Request.Params["pass"] == null)
            {
               // string scriptString = "alert(" + "'请输入密码'" + ");";
                //Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "warning", scriptString, true); //chongdingxaing
                Response.Write("<script>alert('请输入密码');</script>");  
            

            }
            else {
                string staff = Request.Params["user"].ToString();
                string pw = Request.Params["pass"].ToString();
                int t1 = s.isstaffname(staff);
                if (t1 == 0)
                {

                Response.Write("<script>alert('用户名不正确');window.location = 'loginform.html';</script>");  
                // Alert(str1);
            }
                else {
                    int t2 = s.ispass(staff, pw);
                    if (t2 == 0) {

                    Response.Write("<script>alert('密码不正确');window.location = 'loginform.html';</script>");      
                    //Alert(str1);

                }
                    //else 登录成功 重定向"
                    else{
                       // HttpSession session=
                        Session["staffname"] = staff;
                       //Response.Redirect("HomePage.html");
                       Response.Write("<script>alert('欢迎" + Session["staffname"] + ",您成功登录!');location.href='HomePage.aspx';</script>");
                    //Response.Redirect("HomePage.html");
                }
                // HttpSession session = request.getSession();
                // session.setAttribute("username", staff);
            }

            }
        }
    
    
}