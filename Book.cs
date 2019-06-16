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
/// book 的摘要说明
/// </summary>
public class Book
{
    int HouseID;
    int clientID;
    string staffname;
    string bookdata;
    string bookstate;
	public Book()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public DataSet Getbook(int HouseID)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("select Staffname,ClientName,bookdata,bookstate,ClientTel from book,client where book.clientID=client.ClientID and HouseID='"+HouseID+"'", conn);
        DataSet ds = new DataSet();
        ad.Fill(ds);
        conn.Close();
        return ds;

    }
    public DataSet GetMybook(string Staffname)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("select HouseID,ClientName,bookdata,bookstate from book,client where book.clientID=client.ClientID and Staffname='" + Staffname + "'", conn);
        DataSet ds = new DataSet();
        ad.Fill(ds);
        conn.Close();
        return ds;

    }
    public string Insertbook(int HouseID,int clientID,string staffname,string bookdata,string bookstate)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("insert into book(Staffname,HouseID,ClientID,bookdata,bookstate) values('" + staffname + "','" + HouseID + "','" + clientID + "','" + bookdata + "','"+bookstate+"')", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }
    public string Updatebook(int HouseID, int clientID, string staffname, string bookdata,string bookstate)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("update book set bookdata='" + bookdata + "',bookstate='"+bookstate+"'where ClientID='" + clientID + "'AND Staffname='"+staffname+"'AND HouseID='"+HouseID+"'", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }
    public string Updatebookstate(int HouseID, int clientID, string staffname, string bookstate)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("update book set bookstate='" + bookstate + "' where ClientID='" + clientID + "'AND Staffname='" + staffname + "'AND HouseID='" + HouseID + "'", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";
    }
    public int getbookcount(int HouseID)
    {
        int bookstate;
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("select * from book where HouseID='"+HouseID+"'And bookstate!='003'", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cm);
        DataSet ds = new DataSet();
        sda.Fill(ds, "table");
        bookstate = ds.Tables["table"].Rows.Count;
        conn.Close();
        return bookstate;

    }
    public string Deletebook(string staffname,int clientID)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("delete from book where Staffname='" + staffname + "'And clientID='" + clientID + "'", conn);
        cm.ExecuteNonQuery();
        conn.Close();
        return "success";

    }
    public int getclientid(string name) {
        int id = 999999999;
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("select ClientID from client where ClientName='" + name + "'", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cm);
        DataSet ds = new DataSet();
        sda.Fill(ds, "table");
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string temp = "";
            temp = ds.Tables[0].Rows[0][0].ToString();
            int.TryParse(temp, out id);
            conn.Close();

            return id;
        }
        else
        {
            conn.Close();
            return id;
        }
    
    }
    public string getownname(int HouseID)
    {
        string own;
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("select Staffname from keylog where HouseID='" + HouseID + "'", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cm);
        DataSet ds = new DataSet();
        sda.Fill(ds, "table");
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            own = ds.Tables[0].Rows[0][0].ToString();
            return own;
        }
        else return "";
    }
    public string getowntel(string name)
    {
        string tel;
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("select StaffTel from staff where Staffname='" + name + "'", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cm);
        DataSet ds = new DataSet();
        sda.Fill(ds, "table");
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            tel = ds.Tables[0].Rows[0][0].ToString();

            return tel;
        }
        else return "";
    }
    

    }
    
    /*public string getbookdata()
    {
        string bookdata;
        string ConnectionString = ConfigurationManager.ConnectionStrings["houseConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        SqlCommand cm = new SqlCommand("select * from book", conn);
        SqlDataAdapter sda = new SqlDataAdapter(cm);
        DataSet ds = new DataSet();
        sda.Fill(ds, "table");
        id = ds.Tables["table"].Rows.Count;
        conn.Close();
        return bookdata;

    }*/


