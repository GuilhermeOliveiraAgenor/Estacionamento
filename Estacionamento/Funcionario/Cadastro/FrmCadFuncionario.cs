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
using Estacionamento;
using Estacionamento.Login;

namespace Estacionamento
{
    public partial class FrmCadFuncionario : Form
    {
        //iniciar as classes
        Funcionario funcionario = new Funcionario();
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            //limpa os campos textbox
            txtFuncionario.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtSalario.Clear();
            txtProfissao.Clear();
            txtSenha.Clear();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //TODO: alterar, excluir funcionario e arrumar cadastro de funcionario

            bool result = false;
            //passa os parametros do text para a classe
            funcionario.primeiroNome = txtFuncionario.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Rg = txtRg.Text;
            funcionario.Profissao = txtProfissao.Text;
            funcionario.Salario = Convert.ToDecimal(txtSalario.Text);
            
            result = funcionarioDAO.inserirFuncionario(funcionario);//retorna o resultado da funcao
            
            if (result == true)
            {
                MessageBox.Show("Cadastro concluido com sucesso", "Concluido", MessageBoxButtons.OK,MessageBoxIcon.Information);
                limparCampos();
            }
            if (result == false)//se for false
            {
                txtFuncionario.Focus();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //vai para tela de login
            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
            this.Hide();

        }
    }
}
