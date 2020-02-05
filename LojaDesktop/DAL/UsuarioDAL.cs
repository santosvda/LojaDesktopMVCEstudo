using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LojaDesktop.Modelos;
using System.Data;

namespace LojaDesktop.DAL
{
    class UsuarioDAL
    {
        Conexao conexao = new Conexao();

        public void Incluir(Usuario usuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "insert into usuario(nome,senha,fk_id_tipo,ativo) values(@nome,@senha,@id_tipo,@ativo)";
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@id_tipo", usuario.Id_tipo);
                cmd.Parameters.AddWithValue("@ativo", usuario.Ativo);

                cmd.Connection = Conexao.cn;

                conexao.conecta();
                usuario.Id_usuario = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro:" + ex.Message);

            }

            catch (Exception ex)

            {

                throw new Exception(ex.Message);

            }

            finally

            {

                conexao.desconecta();

            }

        }

        public int Logar(Usuario usuario)
        {
            try
            {
                int linhas = 0;
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select nome,senha,fk_id_tipo,ativo from usuario where nome=@nome and senha=@senha";
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);

                cmd.Connection = Conexao.cn;

                conexao.conecta();

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    linhas++;
                }

                return linhas;
                
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

                conexao.desconecta();

            }

        }

        public DataTable Listagem()

        {

            DataTable tabela = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("select id_usuario,nome,senha,ativo,fk_id_tipo from usuario", Dados.StringDeConexao);

            da.Fill(tabela);

            return tabela;

        }

    }
}
