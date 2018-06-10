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
    public class UnidadeDAL
    {
        public List<Unidade> Listar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;

            List<Unidade> lst = new List<Unidade>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "select * from tb_unidade";

                    SqlDataReader reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    lst = Unidade.PopularLista(reader);
                }
            }
            return lst;
        }

        public void Insert(Unidade unidade)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                using(SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "INSERT INTO tb_UNIDADE (NOME, ENDERECO, BAIRRO, TELEFONE, EMAIL, COD_CIE) VALUES (@NOME, @ENDERECO, @BAIRRO, @TELEFONE, @EMAIL, @CODCIE)";
                    comando.Parameters.Add(new SqlParameter("@NOME", unidade.nome));
                    comando.Parameters.Add(new SqlParameter("@ENDERECO", unidade.endereco));
                    comando.Parameters.Add(new SqlParameter("@BAIRRO", unidade.bairro));
                    comando.Parameters.Add(new SqlParameter("@TELEFONE", unidade.telefone));
                    comando.Parameters.Add(new SqlParameter("@EMAIL", unidade.email));
                    comando.Parameters.Add(new SqlParameter("@CODCIE", unidade.codcie));

                    comando.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }

                public Unidade buscaue(int uni)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["bancodedados"].ConnectionString;
                    Unidade un;

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            using (SqlCommand comando = new SqlCommand())
                            {
                                comando.Connection = conn;
                                conn.Open();
                                comando.CommandType = System.Data.CommandType.Text;
                                comando.CommandText = "SELECT * FROM TB_UNIDADE WHERE ID_UNIDADE = " + uni;

                                SqlDataReader reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                                reader.Read();
                                un = Unidade.Popular(reader);

                                conn.Close();
                            }
                        }
                    }
                    catch
                    {
                        un = null;
                    }
                    return un;
                }
    }
}
