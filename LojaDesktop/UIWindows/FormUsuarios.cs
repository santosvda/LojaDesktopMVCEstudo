using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojaDesktop.Modelos;
using LojaDesktop.BLL;


namespace LojaDesktop.UIWindows
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }
        
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Id_tipo = Convert.ToInt32(cmbTipo.SelectedValue);
                usuario.Ativo = chboxAtivo.Checked == true ? true : false;

                UsuarioBLL user = new UsuarioBLL();
                user.Incluir(usuario);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                TipoBLL tipos = new TipoBLL();

                List<Tipo> tipo = tipos.ListarTiposCombo();

                cmbTipo.DataSource = tipo;
                cmbTipo.DisplayMember = "descricao";
                cmbTipo.ValueMember = "id_tipo";


                UsuarioBLL obj = new UsuarioBLL();
                dgvUsuarios.DataSource = obj.Listagem();



                lblCod.Text = dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value.ToString();

                txtNome.Text = dgvUsuarios[1, dgvUsuarios.CurrentRow.Index].Value.ToString();

                txtSenha.Text = dgvUsuarios[2, dgvUsuarios.CurrentRow.Index].Value.ToString();

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
