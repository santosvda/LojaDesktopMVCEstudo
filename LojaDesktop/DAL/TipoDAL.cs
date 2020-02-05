using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LojaDesktop.Modelos;

namespace LojaDesktop.DAL
{
    class TipoDAL
    {
        Conexao conexao = new Conexao();

        public List<Tipo> ListarTiposCombo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select id_tipo, descricao from tipo where ativo = 1";
                cmd.Connection = Conexao.cn;
                conexao.conecta();
                SqlDataReader dr = cmd.ExecuteReader();

                List<Tipo> tipos = new List<Tipo>();

                // quando acabar as linhas que retornou da consulta, sai do While
                while (dr.Read())
                {
                    Tipo tipo = new Tipo();
                    tipo.Id_tipo = dr.GetInt32(dr.GetOrdinal("id_tipo"));
                    tipo.Descricao = dr.GetString(dr.GetOrdinal("descricao"));
                    tipos.Add(tipo);
                }

                cmd.Dispose();

                return tipos;
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
    }
}
