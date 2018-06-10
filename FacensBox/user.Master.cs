using BL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacensBox
{
    public partial class user : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["usuario"];

            Response.BufferOutput = true;
            if (Session["usuario"] == null)
                Response.Redirect("Default.aspx");

            lbluser.Text = u.nome;
            Session["username"] = u.usuario; 
        }

        protected void btnsair_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}