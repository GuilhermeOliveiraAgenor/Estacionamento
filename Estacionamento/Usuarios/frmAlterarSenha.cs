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

namespace Estacionamento.Usuarios
{
    public partial class frmAlterarSenha : Form
    {
        Usuario usuario = new Usuario();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool result = false;
            string cpf = loginUsuario.getCpf();//parametro

            usuario.Senha = txtConfirmar.Text;
            usuario.Cpf = cpf;
        
            result = usuarioDAO.alterarSenha(usuario);//recebe o resultado
           
            if (result == true)
            {
               MessageBox.Show("Concluido com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenuu frm = new frmMenuu();
            frm.Show();
            this.Hide();
        }
    }
}
