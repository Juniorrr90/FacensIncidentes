using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Unidade
    {
        public int id_unidade{ get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int codcie { get; set; }

        public static List<Unidade> PopularLista(SqlDataReader reader)
        {
            List<Unidade> lst = new List<Unidade>();

            while (reader.Read())
            {
                lst.Add(Popular(reader));
            }
            return lst;
        }

        public static Unidade Popular(SqlDataReader reader)
        {
            Unidade u = new Unidade();

            try
            {
                u.id_unidade = reader.GetInt32(reader.GetOrdinal("ID_Unidade"));
                u.nome = reader.GetString(reader.GetOrdinal("Nome"));
                u.endereco = reader.GetString(reader.GetOrdinal("Endereco"));
                u.bairro = reader.GetString(reader.GetOrdinal("Bairro"));
                u.telefone = reader.GetString(reader.GetOrdinal("Telefone"));
                u.email = reader.GetString(reader.GetOrdinal("Email"));
                u.codcie = reader.GetInt32(reader.GetOrdinal("Cod_CIE")); 
            }
            catch
            {
                u = null;
            }

            return u;
        }
    }
}
