using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacensBox
{
    public partial class FechaChamado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!Page.IsPostBack)
            {
                ddlestado.Items.Insert(0, new ListItem("Aberto", "0"));
                ddlestado.Items.Insert(1, new ListItem("Encerrado", "1"));
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}