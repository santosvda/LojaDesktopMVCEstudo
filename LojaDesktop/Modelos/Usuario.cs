using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDesktop.Modelos
{
    class Usuario
    {
        private int id_usuario;
        private string nome;
        private string senha;
        private int id_tipo;
        private bool ativo;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
