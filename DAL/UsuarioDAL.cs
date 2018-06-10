using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public List<Usuario> Listar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;

            List<Usuario> lst = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "select * from tb_usuario";

                    SqlDataReader reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    lst = Usuario.PopularLista(reader);
                }
            }
            return lst;
        }

        public void Insert(Usuario usuario)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                using(SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "INSERT INTO tb_USUARIO (USUARIO, NOME, SENHA, EMAIL, ID_Unidade, NIVEL) VALUES ( @USUARIO, @NOME, @SENHA, @EMAIL, @ID_UNIDADE, @NIVEL)";
                    comando.Parameters.Add(new SqlParameter("@USUARIO", usuario.usuario));
                    comando.Parameters.Add(new SqlParameter("@NOME", usuario.nome));
                    comando.Parameters.Add(new SqlParameter("@SENHA", usuario.senha));
                    comando.Parameters.Add(new SqlParameter("@EMAIL", usuario.email));
                    comando.Parameters.Add(new SqlParameter("@ID_Unidade", usuario.id_unidade));
                    comando.Parameters.Add(new SqlParameter("@NIVEL", usuario.nivel));

                    comando.ExecuteNonQuery();

                    conn.Close();
                }
            }

        }

        public Usuario validar(string auxuser, string auxsenha)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;
            Usuario user;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conn;
                        conn.Open();
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.CommandText = "SELECT * FROM tb_usuario WHERE usuario = '" + auxuser + "' AND senha = '" + auxsenha +"'";

                        SqlDataReader reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                        user = Usuario.Popular(reader);

                        conn.Close();
                    }
                }
            }
            catch {
                user = null;
            }
            return user;
        }

        

        public Usuario recsenha(string auxemail)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;
            Usuario user;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conn;
                        conn.Open();
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.CommandText = "SELECT * FROM tb_usuario WHERE EMAIL = '" + auxemail +"'";

                        SqlDataReader reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                        user = Usuario.Popular(reader);

                        conn.Close();
                    }
                }
            }
            catch {
                user = null;
            }
            return user;
        }
    }
}
