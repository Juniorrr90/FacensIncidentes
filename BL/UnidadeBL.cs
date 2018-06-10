using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BL
{
    public class UnidadeBL
    {
        private UnidadeDAL unidadeDAL;
        public UnidadeBL()
        {
            unidadeDAL = new UnidadeDAL();
        }


        public List<Unidade> Listar()
        {
            return unidadeDAL.Listar();
        }

        public void Inserir(Unidade user)
        {
            unidadeDAL.Insert(user);
        }


        public Unidade BuscaUe(int uni)
        {
            Unidade un;

            un = unidadeDAL.buscaue(uni);

            return un;
        }
    }
}
