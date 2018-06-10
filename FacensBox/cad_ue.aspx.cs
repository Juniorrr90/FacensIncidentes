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
    public partial class cad_ue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Unidade user = new Unidade();
            Response.BufferOutput = true;

            user.nome = nome.Text;
            user.endereco = end.Text;
            user.bairro = bairro.Text;
            user.telefone = telefone.Text;
            user.email = email.Text;
            user.codcie = Convert.ToInt32(codcie.Text);

            UnidadeBL bl = new UnidadeBL();
            bl.Inserir(user);

            Response.Redirect("Inicio.aspx");
        }
    }
}