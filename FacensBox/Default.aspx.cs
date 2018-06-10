using BL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace FacensBox
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            if (Session["usuario"] != null)
                Response.Redirect("Inicio.aspx");

            loginusername.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string auxuser;
            string auxsenha;
            int nivel;
            Usuario user;
            Unidade un;
            Response.BufferOutput = true;

            auxuser = loginusername.Text;
            auxsenha = loginpassword.Text;

            UsuarioBL b2 = new UsuarioBL();
            UnidadeBL bn = new UnidadeBL();

            user = b2.Validar(auxuser, auxsenha);
            
            if (user != null && user.usuario != "")
            {
                Session["usuario"] = user;
                un = bn.BuscaUe(user.id_unidade);
                Session["unidade"] = un;

                nivel = user.nivel;

                //0 - adm.....1 - tec.....2 - user
                if(nivel == 0)
                {
                    Response.Redirect("Inicio.aspx");
                }
                else if(nivel == 1)
                {
                    Response.Redirect("tecInicio.aspx");
                }
                else
                {
                    Response.Redirect("userInicio.aspx");
                }
            }
            else
                Response.Redirect("Default.aspx");
        }

        protected void btnRec_Click(object sender, EventArgs e)
        {
            string email = "shdsme@gmail.com";
            string senha = "m1c@r3t4shd";
            string servidor = "smtp.gmail.com";
            int porta = 587;
            
            string auxemail = txtrecsenha.Text;
            UsuarioBL b3 = new UsuarioBL();
            Usuario ue;

            ue = b3.RecSenha(auxemail);

            if (ue != null && ue.usuario != "")
            {
                string emailPara = ue.email;
                StringBuilder texto = new StringBuilder();
                texto.AppendLine("Olá: " + ue.nome);
                texto.AppendLine("Segue abaixo as informações para login no SHD");
                texto.AppendLine("Usuário: " + ue.usuario);
                texto.AppendLine("Senha: " + ue.senha);
                
                SmtpClient smtp = new SmtpClient(servidor, porta);
                smtp.Credentials = new NetworkCredential(email, senha);
                smtp.EnableSsl = true;

                MailMessage mensagem = new MailMessage(email, emailPara);
                mensagem.Subject = "Lembrete de Senha - SHD";
                mensagem.Body = texto.ToString();

                smtp.Send(mensagem);
            }
            else
            {
                lblerro.Visible = true;
            }
        }
    }
}