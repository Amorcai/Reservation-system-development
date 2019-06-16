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
/// Staff 的摘要说明
/// </summary>
public class Staff
{
    int StaffID;
    string Staffname;
    string Staffpass;
    string StaffTel;
    public Staff()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public DataSet GetAllStaff()
    {//返回所有部门代码（code列）及名称（name列）列表
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("select * from staff", conn);
        DataSet ds = new DataSet();
        ad.Fill(ds);
        conn.Close();
        return ds;
    }
    public string InsertStaff(int StaffID, string Staffname, string Staffpass, string StaffTel)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("insert into staff(clientID,ClientName,ClientGender,ClientTel) values('" + StaffID + "','" + Staffname + "','" + Staffpass + "','" + StaffTel + "')", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }
    public string UpdateStafftel(int StaffID, string Staffname, string Staffpass, string StaffTel)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("update staff set StaffTel='" + StaffTel + "' where StaffID='" + StaffID + "'", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }
    public string UpdateStaffpass(int StaffID, string Staffname, string Staffpass, string StaffTel)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("update staff set Staffpass='" + Staffpass + "' where StaffID='" + StaffID + "'", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }
    public int isstaffname(string name) {
        int Flags = 0;
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("select * from staff", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cm);
        DataSet ds = new DataSet();
        sda.Fill(ds, "table");
        foreach (DataRow mDr in ds.Tables[0].Rows)
        {
            if (name == mDr[0].ToString())
            {
                Flags = 1;
                break;
            }
            else Flags = 0;
            
        }
     
        conn.Close();
        return Flags;
    }
    public int ispass(string name,string pass)
    {
        int Flags = 0;
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("select Staffpass from staff where Staffname='"+name+"'", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cm);
        DataSet ds = new DataSet();
        sda.Fill(ds, "table");
        foreach (DataRow mDr in ds.Tables[0].Rows)
        {
            if (pass == mDr[0].ToString())
            {
                Flags = 1;
                break;
            }
            else Flags = 0;

        }

        conn.Close();
        return Flags;
    }
}