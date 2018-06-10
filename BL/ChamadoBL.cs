using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BL
{
    public class ChamadoBL
    {
        private ChamadoDAL chamadoDAL;
        public ChamadoBL()
        {
            chamadoDAL = new ChamadoDAL();
        }

        public List<Chamado> Listar()
        {
            return chamadoDAL.Listar();
        }

        public List<Chamado> ListarAbertos()
        {
            return chamadoDAL.ListarAbertos();
        }

        public List<Chamado> ListarAbertosUser(String user)
        {
            return chamadoDAL.ListarAbertosUser(user);
        }

        public List<Chamado> ListarEncerrados()
        {
            return chamadoDAL.ListarEncerrados();
        }

        public void Inserir(Chamado cham)
        {
            chamadoDAL.Insert(cham);
        }
    }
}
