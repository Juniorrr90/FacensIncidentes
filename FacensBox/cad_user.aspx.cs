using BL;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacensBox
{
    public partial class cad_user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conn;
                        conn.Open();
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.CommandText = "select id_unidade, nome from tb_unidade";

                        SqlDataReader reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                        ddlunidade.DataSource = reader;
                        ddlunidade.DataTextField = "nome";
                        ddlunidade.DataValueField = "id_unidade";
                        ddlunidade.DataBind();

                        conn.Close();

                        ddlunidade.Items.Insert(0, new ListItem("Selecione a UE", "0"));
                    }
                }
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            Response.BufferOutput = true;          

            user.usuario = username.Text;
            user.nome = nome.Text;
            user.email = email.Text;
            user.senha = password.Text;
            user.id_unidade = Convert.ToInt32(ddlunidade.SelectedItem.Value);
            user.nivel = Convert.ToInt32(nivel.Text);

            UsuarioBL bl = new UsuarioBL();
            bl.Inserir(user);

            Response.Redirect("Inicio.aspx");
        }
    }
}