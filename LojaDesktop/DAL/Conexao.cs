using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDesktop.Modelos;
using System.Data.SqlClient;

namespace LojaDesktop.DAL
{
    class Conexao
    {
        public static SqlConnection cn = new SqlConnection();
        public void conecta()
        {
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();
            }
            catch (SqlException ex)

            {

                throw new Exception("Servidor SQL Erro:" + ex.Number);

            }

            catch (Exception ex)

            {

                throw new Exception(ex.Message);

            }
        }

        public void desconecta()
        {
            try
            {
                cn.Close();
            }
            catch (SqlException ex)

            {

                throw new Exception("Servidor SQL Erro:" + ex.Number);

            }

            catch (Exception ex)

            {

                throw new Exception(ex.Message);

            }

            finally

            {

                cn.Close();

            }
        }
    }
}
