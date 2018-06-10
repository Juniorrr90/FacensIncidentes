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
    public class ChamadoDAL
    {
        public List<Chamado> Listar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;

            List<Chamado> lst = new List<Chamado>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "select * from tb_chamados";

                    SqlDataReader reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    lst = Chamado.PopularLista(reader);
                }
            }
            return lst;
        }

        public List<Chamado> ListarAbertos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;

            List<Chamado> lst = new List<Chamado>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                   
                    comando.CommandText = "select * from tb_chamados";
                    conn.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                         lst = new List<Chamado>();
                         while (reader.Read())
                         {
                             lst.Add(Chamado.Popular(reader));
                         }
                    }
                }
            }
            return lst;
        }

        public void DeleteChamado(Chamado chamado) {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.CommandText = "delete from tb_chamados WHERE id_chamado = '" + chamado.id_chamado + "'";
                    
                    conn.Close();
                }
            }
        }

        public List<Chamado> ListarAbertosUser(String user)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;

            List<Chamado> lst = new List<Chamado>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;

                    comando.CommandText = "select * from tb_chamados WHERE id_usuario = '"+user+"'";
                    conn.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        lst = new List<Chamado>();
                        while (reader.Read())
                        {
                            lst.Add(Chamado.Popular(reader));
                        }
                    }
                }
            }
            return lst;
        }

        public List<Chamado> ListarEncerrados()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;

            List<Chamado> lst = new List<Chamado>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "select * from tb_chamados WHERE estado = Encerrado";

                    SqlDataReader reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    lst = Chamado.PopularLista(reader);
                }
            }
            return lst;
        }

        public void Insert(Chamado chamado)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "INSERT INTO tb_CHAMADOS (ID_UNIDADE, DTABERTURA, ESTADO, PROBLEMA, ID_USUARIO) VALUES (@ID_UNIDADE, '" + chamado.dtabertura + "', @ESTADO, @PROBLEMA, @ID_USUARIO)";
                    //comando.Parameters.Add(new SqlParameter("@ID_CHAMADO", chamado.id_chamado));
                    comando.Parameters.Add(new SqlParameter("@ID_UNIDADE", chamado.id_unidade));
                    comando.Parameters.Add(new SqlParameter("@DTABERTURA", "'" + chamado.dtabertura + "'"));
                    comando.Parameters.Add(new SqlParameter("@ESTADO", chamado.estado));
                    //comando.Parameters.Add(new SqlParameter("@DTATENDIMENTO", "'" + chamado.dtatendimento + "'"));
                    comando.Parameters.Add(new SqlParameter("@PROBLEMA", chamado.problema));
                    //comando.Parameters.Add(new SqlParameter("@SOLUCAO", chamado.solucao));
                    comando.Parameters.Add(new SqlParameter("@ID_USUARIO", chamado.id_usuario));
                    //comando.Parameters.Add(new SqlParameter("@ID_TECNICO", chamado.id_tecnico));

                    comando.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }
    }
}
