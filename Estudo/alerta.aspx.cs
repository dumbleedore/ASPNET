using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estudo
{
    public partial class alerta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            var text = textocaixa.Text;
            Response.Write("<script>alert('" + text + "')</script>");
            Response.Write(text);
        }
    }
}