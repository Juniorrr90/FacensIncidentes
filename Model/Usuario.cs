using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        public string usuario { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public int id_unidade { get; set; }
        public int nivel { get; set; }


        public static List<Usuario> PopularLista(SqlDataReader reader)
        {
            List<Usuario> lst = new List<Usuario>();

            while (reader.Read())
            {
                lst.Add(Popular(reader));
            }
            return lst;
        }

        public static Usuario Popular(SqlDataReader reader)
        {
            Usuario u = new Usuario();

            try
            {
                reader.Read();
                u.usuario = reader.GetString(reader.GetOrdinal("Usuario"));
                u.nome = reader.GetString(reader.GetOrdinal("Nome"));
                u.senha = reader.GetString(reader.GetOrdinal("Senha"));
                u.email = reader.GetString(reader.GetOrdinal("Email"));
                u.id_unidade = reader.GetInt32(reader.GetOrdinal("ID_unidade"));
                u.nivel = reader.GetInt32(reader.GetOrdinal("Nivel"));
            }
            catch
            {
                u = null;
            }

            return u;
        }

    }
}
