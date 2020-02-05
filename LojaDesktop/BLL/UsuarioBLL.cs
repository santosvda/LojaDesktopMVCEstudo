using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDesktop.Modelos;
using LojaDesktop.DAL;
using System.Data;



namespace LojaDesktop.BLL
{
    class UsuarioBLL
    {
        public void Incluir(Usuario usuario)

        {

            //O nome do cliente é obrigatório
            //trim retira espaços a esquerda e a direita
            if (usuario.Nome.Trim().Length == 0)

            {

                throw new Exception("O nome do cliente é obrigatório");

            }

            //Se tudo está Ok, chama a rotina de inserção.

            UsuarioDAL obj = new UsuarioDAL();

            obj.Incluir(usuario);

        }

        public bool Logar(Usuario usuario)
        {
            UsuarioDAL obj = new UsuarioDAL();

            int linhas = obj.Logar(usuario);

            if(linhas == 0)
            {
                throw new Exception("Credenciais incorretas");
            }
            else if(linhas>1)
            {
                throw new Exception("Credenciais cadastradas em mais de 1 usuario");
            }
            else
            {
                return true;
            }
        }

        public DataTable Listagem()

        {

            UsuarioDAL obj = new UsuarioDAL();

            return obj.Listagem();

        }
    }
}
