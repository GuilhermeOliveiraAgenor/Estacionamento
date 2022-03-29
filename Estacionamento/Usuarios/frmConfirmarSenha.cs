using DAO;
using Estacionamento.editarPedidos;
using Estacionamento.Entrada;
using Estacionamento.Menu;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.ControlBox = false;//tirar a borda da tela
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//maximizar a tela
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (String.IsNullOrEmpty(txtSenha.Text))//verificar campo vazio
            {
                MessageBox.Show("Preencha o campo", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

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
        }
        private void ptbAtivarsenha_Click(object sender, EventArgs e)
        {
            ptbAtivarsenha.Visible = false;
            txtSenha.UseSystemPasswordChar = false;
        }

        private void ptbSenha_Click(object sender, EventArgs e)
        {
            ptbAtivarsenha.Visible = true;
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new frmMenuu().Show();
            this.Hide();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInserirVeiculo().Show();
            this.Hide();
        }
        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAlterarCliente().Show();
            this.Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadCliente().Show();
            this.Hide();
        }
        private void ptbMaximar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbNormal.Visible = true;
            ptbMaximar.Visible = false;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbNormal.Visible = false;
            ptbMaximar.Visible = true;
        }

        private void ptbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
