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
using System.IO;

namespace Estacionamento
{
    public partial class FrmCadFuncionario : Form
    {
        //iniciar as classes
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
        Funcionarios funcionario = new Funcionarios();

        DataTable dt = new DataTable();
        string modo = "";
        string caminhoFoto = "";
        byte[] fotoFuncionario;
        int idFuncionario;

        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            //limpa os campos textbox
            txtPrimeironome.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtSalario.Clear();
            txtProfissao.Clear();
            ptbFoto.Image = null;
        }

        public void carregarFunc()
        {
            dgvFuncionario.DataSource = funcionarioDAO.carregarFuncionario();
            dgvFuncionario.Refresh();
        }

        public void carregarFoto()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagens jpg e png|*.jpg; *png";//define os tipos de arquivos
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)//se selecionar a foto, coloca o nome do arquivo na variável
            {
                caminhoFoto = openFile.FileName;
            }
            if (caminhoFoto != "")//se estiver com alguma coisa na variável
            {
                ptbFoto.Load(caminhoFoto);//carrega a foto
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

        private void ptbAtivarsenha_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            carregarFunc();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modo = "Cadastrar";
            MessageBox.Show("Clique em gravar para continuar","Clique para concluir",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            //TODO: alterar funcionario
            bool result;
       
            if (modo == "Cadastrar")
            {
                //*passa os parametros do text para a classe
                funcionario.primeiroNome = txtPrimeironome.Text;
                funcionario.Sobrenome = txtSobrenome.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Rg = txtRg.Text;
                funcionario.Profissao = txtProfissao.Text;
                funcionario.Salario = Convert.ToDecimal(txtSalario.Text);
                funcionario.caminhoFoto = caminhoFoto;
                
                result = funcionarioDAO.inserirFuncionario(funcionario);//retorna o resultado da funcao

                if (result == true)
                {
                    MessageBox.Show("Cadastro concluido com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
            }
            if (modo == "Alterar")
            {

                funcionario.primeiroNome = txtPrimeironome.Text;//parametros
                funcionario.Sobrenome = txtSobrenome.Text;
                funcionario.Rg = txtRg.Text;
                funcionario.Profissao = txtProfissao.Text;
                funcionario.Salario = Convert.ToDecimal(txtSalario.Text);
                funcionario.idFuncionario = idFuncionario;

                result = funcionarioDAO.alterarFuncionario(funcionario);

                if (result == true)
                {
                    MessageBox.Show("Alteração concluida com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }

            }
            if (modo == "alterarFoto")
            {
                funcionario.caminhoFoto = caminhoFoto;//parametro
                funcionario.idFuncionario = idFuncionario;

                result = funcionarioDAO.alterarFoto(funcionario);//recebe o resultado

                if (result == true)
                {
                    MessageBox.Show("Alteração concluida com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                
            }
            if (modo == "Excluir")
            {
 
                result = funcionarioDAO.excluirFuncionario(idFuncionario);//recebe o resultado

                if (result == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
                
            }
                
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            modo = "Alterar";
            MessageBox.Show("Clique em gravar para continuar", "Clique para concluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCpf.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            modo = "Excluir";
            MessageBox.Show("Clique em gravar para continuar", "Clique para concluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCpf_Click(object sender, EventArgs e)
        {
            string cpf = txtPesquisar.Text;//parametro

            dt = funcionarioDAO.selecionarFuncionario(cpf);//recebe o resultado

            if (dt.Rows.Count == 1)//se linhas forem afetadas, carrega o dt
            {
                MessageBox.Show("Funcionario encontrado", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ptbEditar.Visible = true;

                    foreach (DataRow row in dt.Rows)
                    {
                        txtPrimeironome.Text = row["primeiroNome"].ToString();
                        txtSobrenome.Text = row["Sobrenome"].ToString();
                        txtRg.Text = row["Rg"].ToString();
                        txtSalario.Text = row["Salario"].ToString();
                        txtCpf.Text = row["Cpf"].ToString();
                        txtProfissao.Text = row["Profissao"].ToString();
                        idFuncionario = row["idFuncionario"].GetHashCode();
                        fotoFuncionario = (byte[])row["Foto"];
                        funcionario.foto = fotoFuncionario;
                    

                    using (var foto = new MemoryStream(funcionario.foto))//carrega a foto
                    {
                        ptbFoto.Image = Image.FromStream(foto);//adiciona a foto
                    }
                }
                
             }
                else
            {
                MessageBox.Show("Erro ao encontrar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregarFoto();
        }

        private void ptbEditar_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagens jpg e png|*.jpg; *png";//define os tipos de arquivos
            openFile.Multiselect = false;

            modo = "alterarFoto";

            if (openFile.ShowDialog() == DialogResult.OK)//se selecionar a foto, coloca o nome do arquivo na variável
            {
                caminhoFoto = openFile.FileName;
            }
            if (caminhoFoto != "")//se estiver com alguma coisa na variável
            {
                ptbFoto.Load(caminhoFoto);//carrega a foto
            }
        }
    }
}
