using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// keylog 的摘要说明
/// </summary>
public class keylog
{
    int HouseID;
    string staffname;
    string deliver;
    string keytime;
    public keylog()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public DataSet Getkey(string name)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("select* from keylog where staffname!='" + name + "'", conn);
        DataSet ds = new DataSet();
        ad.Fill(ds);
        conn.Close();
        return ds;

    }
    public string Updatekey(int HouseID,string staff, string ex, string time)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("update keylog set Time='" + time + "',Staffname='" + staff + "',deliver='" + ex + "'where HouseID='" + HouseID + "'", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }



}