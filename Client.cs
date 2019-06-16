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
/// Client 的摘要说明
/// </summary>
public class Client
{
    int clientID;
    string Clientname;
    string Clientgender;
    string tel;
    public Client()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public DataSet GetAllClient()
    {//返回所有部门代码（code列）及名称（name列）列表
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("select * from client", conn);
        DataSet ds = new DataSet();
        ad.Fill(ds);
        conn.Close();
        return ds;
    }
    public string InsertClient(int clientID,string Clientname,string Clientgender,string tel)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("insert into client(ClientID,ClientName,ClientGender,ClientTel) values('" + clientID + "','" + Clientname + "','"+Clientgender+"','"+tel+"')", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }
    public string UpdateClienttel(int clientID, string Clientname, string Clientgender, string tel)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("update client set ClientTel='" + tel + "' where ClientID='" + clientID + "'", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }
    public string DeleteDeptByCode(int clientID)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("delete from client where ClientID='" + clientID + "'", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";

    }
    public int getid()
    {
        int id;
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("select * from client", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cm);
        DataSet ds = new DataSet();
        sda.Fill(ds, "table");
        id = ds.Tables["table"].Rows.Count;
        conn.Close();
        return id;

    }
}