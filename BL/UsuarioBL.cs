using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BL
{
    public class UsuarioBL
    {
        private UsuarioDAL usuarioDal;
        public UsuarioBL()
        {
            usuarioDal = new UsuarioDAL();
        }

        public List<Usuario> Listar()
        {
            return usuarioDal.Listar();
        }

        public void Inserir(Usuario user)
        {
            usuarioDal.Insert(user);
        }

        public Usuario Validar(string auxuser, string auxsenha)
        {
            Usuario user;
            user = usuarioDal.validar(auxuser, auxsenha);

            return user;
        }

        public Usuario RecSenha(string email)
        {
            Usuario user;
            user = usuarioDal.recsenha(email);

            return user;
        }
    }
}
