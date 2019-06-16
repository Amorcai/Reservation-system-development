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
/// House 的摘要说明
/// </summary>
public class House
{
    int ID;
    string address;
    string price;
    string type;
	public House()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public DataSet GetAllHouse()
    {//返回所有部门代码（code列）及名称（name列）列表
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("select * from House1", conn);
        DataSet ds = new DataSet();
        ad.Fill(ds);
        conn.Close();
        return ds;
    }
    public string InsertHouse(int ID,string address, string price, string type)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("insert into House1(HouseID,address,price,type) values('"+ID+"','" + address + "','" + price + "','" + type + "')", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }
    public string UpdateHouse(int ID, string address)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("update House1 set address='" + address + "' where HouseID='" + ID + "'", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }
    public string DeleteHouseByCode(int ID)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("delete from House1 where HouseID='" + ID + "'", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";

    }
    public int gethouseid()
    {
        int id;
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("select * from House1", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cm);
        DataSet ds = new DataSet();
        sda.Fill(ds, "table");
        id = ds.Tables["table"].Rows.Count;
        conn.Close();
        return id;

    }
}