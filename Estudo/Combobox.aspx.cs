using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace Estudo
{
    public partial class Combobox : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        SqlDataAdapter sda = new SqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ds = new DataSet();
                con.ConnectionString = "Data Source=DESKTOP-U9QEEE8;Initial Catalog=Usuario;Integrated Security=True";
                con.Open();
                com.CommandText = "SELECT * FROM Pessoa";
                com.Connection = con;
                com.ExecuteNonQuery();
                sda = new SqlDataAdapter(com);
                sda.Fill(ds);
                ddl.DataSource = ds;
                ddl.DataValueField = "ID";
                ddl.DataTextField = "NAME";
                ddl.DataBind();
            }
           



        }

        protected void button_Click(object sender, EventArgs e)
        {
            string text;
            text = Convert.ToString(ddl.SelectedValue);
            para.InnerText = text;
        }

    }
}