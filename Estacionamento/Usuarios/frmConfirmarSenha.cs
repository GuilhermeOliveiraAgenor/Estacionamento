using DAO;
using Estacionamento.Menu;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.Usuarios
{
    public partial class frmConfirmarSenha : Form
    {
        Usuario usuario = new Usuario();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public frmConfirmarSenha()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            usuario.Senha = txtSenha.Text; 

            dt = usuarioDAO.selecionarSenha(usuario);

            if (dt.Rows.Count == 1)
            {
                frmAlterarSenha frm = new frmAlterarSenha();
                frm.Show();
                this.Hide();
            }
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Erro ao fazer login. Verifique os campos e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
                txtSenha.Focus();
            }
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
