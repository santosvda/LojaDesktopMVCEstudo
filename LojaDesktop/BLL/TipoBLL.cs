using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDesktop.Modelos;
using LojaDesktop.DAL;

namespace LojaDesktop.BLL
{
    class TipoBLL
    {
        public List<Tipo> ListarTiposCombo()
        {
            TipoDAL tipo = new TipoDAL();
            return tipo.ListarTiposCombo();
        }
    }
}
