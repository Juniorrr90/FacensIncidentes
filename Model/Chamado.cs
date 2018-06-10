using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Chamado
    {
        public int id_chamado { get; set; }
        public int id_unidade { get; set; }
        public DateTime dtabertura { get; set; }
        public string estado { get; set; }
        public DateTime? dtatendimento { get; set; }
        public string problema { get; set; }
        public string solucao { get; set; }
        public string id_usuario { get; set; }
        public string id_tecnico { get; set; }

        public static List<Chamado> PopularLista(SqlDataReader reader)
        {
            List<Chamado> lst = new List<Chamado>();

            while (reader.Read())
            {
                lst.Add(Popular(reader));
            }
            return lst;
        }

        public static Chamado Popular(SqlDataReader reader)
        {
            Chamado c = new Chamado();

            try
            {
                c.id_chamado = reader.GetInt32(reader.GetOrdinal("id_chamado"));
                c.id_unidade = reader.GetInt32(reader.GetOrdinal("id_unidade"));
                c.dtabertura = Convert.ToDateTime(reader["dtabertura"]);
                c.estado = reader.GetString(reader.GetOrdinal("estado"));
                if (!reader.IsDBNull(4))
                    c.dtatendimento = Convert.ToDateTime(reader["dtatendimento"]);
                c.problema = reader.GetString(reader.GetOrdinal("problema"));
                if (!reader.IsDBNull(6))
                    c.solucao = reader.GetString(reader.GetOrdinal("solucao"));
                c.id_usuario = reader.GetString(reader.GetOrdinal("id_usuario"));
                if (!reader.IsDBNull(8))
                    c.id_tecnico = reader.GetString(reader.GetOrdinal("id_tecnico"));
            }
            catch(Exception e)
            {
                c = null;
            }

            return c;
        }
    }
}
