using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojaDesktop.UIWindows;
using LojaDesktop.Modelos;
using LojaDesktop.BLL;

namespace LojaDesktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Nome = txtUser.Text;
                usuario.Senha = txtSenha.Text;

                UsuarioBLL obj = new UsuarioBLL();
                bool login = obj.Logar(usuario);
                if (login == true)
                {
                    FormUsuarios form = new FormUsuarios();
                    form.Show();
                }
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

}
    }
}
