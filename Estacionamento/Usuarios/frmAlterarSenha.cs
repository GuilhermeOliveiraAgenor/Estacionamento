using System;
using Model;
using DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamento.Menu;
using Estacionamento.Entrada;
using Estacionamento.Saida;
using Estacionamento.editarPedidos;
using Estacionamento.Login;
using Controller;
using System.Runtime.InteropServices;

namespace Estacionamento.Usuarios
{
    public partial class frmAlterarSenha : Form
    {
        Usuario usuario = new Usuario();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        EstacionarDAO estacionarDAO = new EstacionarDAO();

        int patio1;
        int patio2;
        public frmAlterarSenha()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//maximizar a tela
        }
        public void limparCampos()
        {
            txtConfirmar.Clear();
            txtNovaSenha.Clear();
        }
        public void validarSenha()
        {
            if (txtConfirmar.Text != txtNovaSenha.Text)
            {
                lblSenha.Text = "As senhas não são iguais";
                btnConfirmar.Enabled = false;
            }
            if (txtConfirmar.Text == txtNovaSenha.Text)
            {
                lblSenha.Text = "";
                btnConfirmar.Enabled = true;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool result = false;
            string cpf = loginUsuario.getCpf();//parametro

            if (String.IsNullOrEmpty(txtConfirmar.Text) || String.IsNullOrEmpty(txtNovaSenha.Text))//verificar campo vazio
            {
                MessageBox.Show("Preencha os campos", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                usuario.Senha = txtConfirmar.Text;
                usuario.Cpf = cpf;

                result = usuarioDAO.alterarSenha(usuario);//recebe o resultado

                if (result == true)
                {
                    MessageBox.Show("Concluido com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
            }
            

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new frmConfirmarSenha().Show();
            this.Hide();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmVerificar().Show();
            this.Hide();
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSaida().Show();
            this.Hide();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEditarEstacionar().Show();
            this.Hide();
        }

        private void vagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();


            dt1 = estacionarDAO.vagasPatio1();

            dt2 = estacionarDAO.vagasPatio2();

            if (dt1.Rows.Count >= 1 && dt2.Rows.Count >= 1)
            {
                foreach (DataRow row1 in dt1.Rows)
                {
                    patio1 = row1["Patio1"].GetHashCode();
                }
                foreach (DataRow row2 in dt2.Rows)
                {
                    patio2 = row2["Patio2"].GetHashCode();
                }
                MessageBox.Show("As vagas no patio 1 são: " + patio1 + "\n" + "E no patio 2 são: " + patio2, "Vagas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMenuu().Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginUsuario.logout();
            new frmLogin().Show();
            this.Hide();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInserirVeiculo().Show();
            this.Hide();
        }

        private void ptbAtivarsenha_Click(object sender, EventArgs e)
        {
            ptbAtivarsenha.Visible = false;
            txtNovaSenha.UseSystemPasswordChar = false;
            txtConfirmar.UseSystemPasswordChar = false;
        }

        private void ptbSenha_Click(object sender, EventArgs e)
        {
            ptbAtivarsenha.Visible = true;
            txtNovaSenha.UseSystemPasswordChar = true;
            txtConfirmar.UseSystemPasswordChar = true;
        }
        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            validarSenha();
        }

        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            validarSenha();
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
        private void btnVoltarmenu_Click(object sender, EventArgs e)
        {
            new frmMenuu().Show();
            this.Hide();
        }

    }
}
