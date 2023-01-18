using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using Estacionamento.Menu;
using DAO;
using Estacionamento.Entrada;

namespace Estacionamento.Login
{
    public partial class frmLogin : Form
    {
        Usuario usuario = new Usuario();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmEditarFuncionario frmcad = new FrmEditarFuncionario();
            frmcad.Show();
            this.Hide();

        }

        private void btnSairmenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginfuncionario_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            frmMenuu frmmenu = new frmMenuu();//vai para o menu

            int Nivel;//codigo do nivel do acesso

            if (String.IsNullOrEmpty(txtCpf.Text) || String.IsNullOrEmpty(txtSenha.Text))//verificar campos vazios
            {
                MessageBox.Show("Preencha os campos", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                //passa os parametros
                usuario.Cpf = txtCpf.Text;
                usuario.Senha = txtSenha.Text;

                dt = usuarioDAO.Login(usuario);//recebe o valor do DataTable
                                               //se uma linha for afetada, faz o login
                if (dt.Rows.Count == 1)
                {
                    foreach (DataRow row in dt.Rows)//carrega a informaçoes
                    {
                        Nivel = row["Acesso"].GetHashCode();//recebe o nivel de acesso

                        if (Nivel == 1)//se o nivel pesquisado for igual ao código, faz o login. Nivel 1 - Funcionario
                        {
                            MessageBox.Show("Login concluido com sucesso. Seja bem vindo", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loginUsuario.login(usuario.Cpf, usuario.Senha, Nivel);//faz a autenticação na classe
                            frmmenu.btnFuncionario.Visible = false;
                            frmmenu.btnRelatorio.Visible = false;
                            frmmenu.pictureBox11.Visible = false;
                            frmmenu.pictureBox12.Visible = false;
                            frmmenu.Show();
                            this.Hide();
                        }
                        if (Nivel == 2)//Nivel 2 - Administrador
                        {
                            MessageBox.Show("Login concluido com sucesso. Seja bem vindo", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loginUsuario.login(usuario.Cpf, usuario.Senha, Nivel);//faz a autenticação na classe
                            frmmenu.Show();
                            this.Hide();

                        }
                    }
                }
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Erro ao fazer login. Verifique os campos e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //mensagem de erro
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginUsuario.logout();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMenuu frmmenu = new frmMenuu();//vai para o menu
            frmmenu.Show();
            this.Hide();
        }
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }

        private void ptbAtivarsenha_Click(object sender, EventArgs e)
        {
            ptbAtivarsenha.Visible = false;
            txtSenha.UseSystemPasswordChar = false;

        }

        private void ptbSenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            ptbAtivarsenha.Visible = true;
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
