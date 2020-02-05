using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDesktop.Modelos
{
    class Tipo
    {
        private int id_tipo;
        private string descricao;
        private bool ativo;

        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
