using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Estudo
{
    public partial class Formulario : System.Web.UI.Page
    {
        // CONEXÃO COM O BANCO DE DADOS //
        SqlConnection sql = new SqlConnection();
        // COMANDO A SER EXECUTADO //
        SqlCommand cmd = new SqlCommand();

        // MOSTRAR OS DADOS //
        DataSet ds = new DataSet();

        // CONVERTER DADOS //
        SqlDataAdapter sda = new SqlDataAdapter();

        DataTable dt = new DataTable();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            sql.ConnectionString = "Data Source=DESKTOP-U9QEEE8;Initial Catalog=Usuario;Integrated Security=True";
            sql.Open();
            if (!Page.IsPostBack)
            {
                showData();
            }
       
        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                cmd.CommandText = "INSERT INTO Pessoa (NAME) VALUES('"+ name.Text.ToString() +"')";
                cmd.Connection = sql;
                cmd.ExecuteNonQuery();
                txtsucess.InnerText = "Adicionado Com Sucesso!!!";
                showData();
            }
            catch (Exception err)
            {
                txtsucess.InnerText = "Erro!!!";
            }
            
        }

        public void showData()
        {

            ds = new DataSet();
            cmd.CommandText = "SELECT * FROM Pessoa";
            cmd.Connection = sql;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            pessoatable.DataSource = ds;
            pessoatable.DataBind();
            sql.Close();
            
        }
    }
}