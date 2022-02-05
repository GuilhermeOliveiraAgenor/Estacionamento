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
using DAO;
using Estacionamento.editarPedidos;
using Estacionamento.Menu;
using Estacionamento.Saida;
using Estacionamento.Entrada;
using System.Data.SqlClient;

namespace Estacionamento
{
    public partial class FrmCadFuncionario : Form
    {
        //iniciar as classes
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
        Funcionarios funcionario = new Funcionarios();
        nivelAcesso nivel = new nivelAcesso();
        nivelAcessoDAO nivelDAO = new nivelAcessoDAO();
        Usuario usuario = new Usuario();
        EstacionarDAO estacionarDAO = new EstacionarDAO();

        DataTable dt = new DataTable();
        string modo = "";
        string caminhoFoto = "";
        string perfilPadrao = "../../Resources/icone_perfil.jpg";
        byte[] fotoFuncionario;
        int idFuncionario;
        int acesso;
        int patio1;
        int patio2;

        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            //limpa os campos textbox
            txtPrimeironome.Clear();
            txtSobrenome.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtSalario.Clear();
            txtProfissao.Clear();
            cmbAcesso.Text = "";
            cmbAcesso.Enabled = true;
            idFuncionario = 0;
            acesso = 0;
            ptbFoto.Load(perfilPadrao);
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
        public void desbloquearCampo()
        {
            btnGravar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            txtCpf.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desbloquearCampo();
            btnGravar.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //vai para tela de login
            new frmMenuu().Show();
            this.Hide();

        }

        private void ptbAtivarsenha_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            List<nivelAcesso> nivel = nivelDAO.carregarAcesso();
            carregarFunc();

            foreach (var item in nivel)
            {
                cmbAcesso.Items.Add(item.Nivel);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modo = "Cadastrar";
            MessageBox.Show("Clique em gravar para continuar","Clique para concluir",MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            cmbAcesso.Enabled = false;
            btnGravar.Enabled = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //TODO: tela
            bool result;
            
            if (modo == "Cadastrar")
            {
                if (caminhoFoto == "")//verificar picture box vazio
                {

                    caminhoFoto = perfilPadrao;//adiciona a foto de perfil
                }

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
                        desbloquearCampo();
                        carregarFunc();
                    }
                    
            }
            if (modo == "Alterar")
            {
                funcionario.idFuncionario = idFuncionario;
                funcionario.primeiroNome = txtPrimeironome.Text;//parametros
                funcionario.Sobrenome = txtSobrenome.Text;
                funcionario.Rg = txtRg.Text;
                funcionario.Profissao = txtProfissao.Text;
                funcionario.Salario = Convert.ToDecimal(txtSalario.Text);
                usuario.Acesso = acesso;
                
                result = funcionarioDAO.alterarFuncionario(funcionario,usuario);

                if (result == true)
                {
                    MessageBox.Show("Alteração concluida com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    desbloquearCampo();
                    carregarFunc();
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
                    carregarFunc();
                    limparCampos();
                    desbloquearCampo();
                    txtPesquisar.Clear();
                }
                
            }
            if (modo == "Excluir")
            {
 
                result = funcionarioDAO.excluirFuncionario(idFuncionario);//recebe o resultado

                if (result == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    desbloquearCampo();
                    carregarFunc();
                }
                
            }
                
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            modo = "Alterar";
            MessageBox.Show("Clique em gravar para continuar", "Clique para concluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCpf.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnGravar.Enabled = true;
            cmbAcesso.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            modo = "Excluir";
            MessageBox.Show("Clique em gravar para continuar", "Clique para concluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnGravar.Enabled = true;
            cmbAcesso.Enabled = false;
        }

        private void btnCpf_Click(object sender, EventArgs e)
        {
            string cpf = txtPesquisar.Text;//parametro

            dt = funcionarioDAO.selecionarFuncionario(cpf);//recebe o resultado

            if (dt.Rows.Count >= 1)//se linhas forem afetadas, carrega o dt
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
                        acesso = row["idNivelAcesso"].GetHashCode();
                        cmbAcesso.Text = row["Nivel"].ToString();
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
                carregarFunc();
                limparCampos();
                ptbEditar.Visible = false;
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
                btnAlterar.Enabled = false;
                btnCadastrar.Enabled = false;
                btnExcluir.Enabled = false;
                btnGravar.Enabled = true;
            }
          
        }

        private void cmbAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<nivelAcesso> nivel = nivelDAO.carregarAcesso();

            foreach (var item in nivel)
            {
                if (cmbAcesso.Text == item.Nivel)//se o item clicado for igual ao item da lista, retorna o id
                {
                    acesso = item.idNivelAcesso.GetHashCode();//retorna o id
                }
            }
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
            new frmAlterarEstacionar().Show();
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

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAlterarCliente().Show();
            this.Hide();
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
            new frmInserirCliveiculo().Show();
            this.Hide();
        }
    }
}
