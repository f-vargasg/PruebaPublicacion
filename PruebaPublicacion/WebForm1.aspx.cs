using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaPublicacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMsg.Text = string.Empty;
            }
        }

        protected void butDo_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Hola mundo";
        }
    }
}