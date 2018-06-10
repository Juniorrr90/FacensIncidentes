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
    public partial class abrechamado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["usuario"];
            Unidade strue = (Unidade)Session["unidade"];

            Response.BufferOutput = true;
            if (Session["usuario"] == null)
                Response.Redirect("Default.aspx");

            txtusr2.Text = u.usuario;
            Session["username"] = u.usuario;
            ue.Text = strue.nome;
            ue.ReadOnly = true;
            txtusr2.ReadOnly = true;
            dtabertura.Text = Convert.ToString(System.DateTime.Now);
            dtabertura.ReadOnly = true;
            estado.ReadOnly = true;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Chamado cham = new Chamado();
            Unidade strue = (Unidade)Session["unidade"];
            Response.BufferOutput = true;

            cham.id_unidade = strue.id_unidade;
            cham.dtabertura = Convert.ToDateTime(dtabertura.Text);
            cham.estado = estado.Text;
            cham.problema = problema.Text;
            cham.id_usuario = txtusr2.Text;

            ChamadoBL bl = new ChamadoBL();
            bl.Inserir(cham);

            Response.Redirect("Inicio.aspx");
        }
    }
}