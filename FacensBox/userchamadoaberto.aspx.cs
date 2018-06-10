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
    public partial class userchamadoaberto : System.Web.UI.Page
    {
        String aux;

        ChamadoBL business = new ChamadoBL();
        UnidadeBL businessUnidade = new UnidadeBL(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["usuario"];
            aux = u.usuario;

            if (!this.IsPostBack)
            {
                this.BindRepeater();
            }
        }

        private void BindRepeater()
        {
            var list = business.ListarAbertosUser(aux);
            var listUnidades = businessUnidade.Listar();

            var listaViewModel = new List<ChamadosAbertosViewModel>();

            foreach (var item in list)
	        {
                var unidade = listUnidades.FirstOrDefault(f => f.id_unidade == item.id_unidade);

                var chamadoViewModel = new ChamadosAbertosViewModel(item, unidade);
                listaViewModel.Add(chamadoViewModel);
	        }

            rptCustomers.DataSource = listaViewModel;
            rptCustomers.DataBind();
        }

        protected void rptCustomers_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int chamadoId = Convert.ToInt32(e.CommandArgument.ToString());

        }
        
        protected void btnImprimir_Click(Chamado c)

        {
          

            //var button = (Button)sender;
            
            //var tag = button.C
        }
    }

    public class userChamadosAbertosViewModel
    {
        public int Id { get; set; }
        public string Unidade { get; set; }
        public string DataAbertura { get; set; }
        public string Problema { get; set; }

        public userChamadosAbertosViewModel(Chamado chamado, Unidade unidade)
        {
            Id = chamado.id_chamado;
            Unidade = unidade.nome;
            DataAbertura = chamado.dtabertura.ToString("dd/MM/yyyy hh:mm");
            Problema = chamado.problema;
        }
    }
}