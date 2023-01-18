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
using System.Runtime.InteropServices;

namespace Estacionamento
{
    public partial class FrmEditarFuncionario : Form
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
        static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();//abre o arquivo local
        string iconPadrao = caminho + "/icon/icone_perfil.jpg";
        byte[] fotoFuncionario;
        int idFuncionario;
        int acesso;
        int patio1;
        int patio2;
        public FrmEditarFuncionario()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//maximizar a tela
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
            txtPesquisar.Clear();
            cmbAcesso.Text = "";
            cmbAcesso.Enabled = true;
            idFuncionario = 0;
            acesso = 0;
            ptbFoto.Load(iconPadrao);
            caminhoFoto = "";
            btnGravar.Enabled = false;
            btnCarregar.Enabled = false;
            ptbEditar.Visible = false;
            cmbAcesso.Enabled = false;
        }

        public void limparPesquisa()
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
            ptbFoto.Load(iconPadrao);
            caminhoFoto = "";
            btnGravar.Enabled = false;
            btnCarregar.Enabled = false;
            ptbEditar.Visible = true;
            txtPesquisar.Focus();
            cmbAcesso.Enabled = false;
        }

        public void carregarFunc()
        {
            dgvFuncionario.DataSource = funcionarioDAO.carregarFuncionario();
        }
        public void validarCampos()
        {
            
        }
        public void carregarFoto()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Todos os arquivos(*.*)";//define os tipos de arquivos
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
            txtCpf.Enabled = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desbloquearCampo();
            btnGravar.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //vai para o Menu
            new frmMenuu().Show();
            this.Hide();
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
            MessageBox.Show("Clique em gravar para continuar", "Clique para concluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
            txtCpf.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            cmbAcesso.Enabled = false;
            ptbEditar.Visible = false;
            btnGravar.Enabled = true;
            btnCarregar.Enabled = true;
            cmbAcesso.Enabled = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bool result;

            if (modo == "")
            {
                MessageBox.Show("Selecione uma das opções para gravar", "Selecione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (String.IsNullOrEmpty(txtPrimeironome.Text) || String.IsNullOrEmpty(txtSobrenome.Text) || String.IsNullOrEmpty(txtCpf.Text)//verificar campos vazios
                || String.IsNullOrEmpty(txtSalario.Text) || String.IsNullOrEmpty(txtProfissao.Text))
            {
                MessageBox.Show("Preencha os campos", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                if (modo == "Cadastrar")
                {
                    if (caminhoFoto == "")//verificar picture box vazio
                    {
                        caminhoFoto = iconPadrao;//adiciona a foto de perfil
                    }

                    //*passa os parametros do text para a classe
                    funcionario.primeiroNome = txtPrimeironome.Text;
                    funcionario.Sobrenome = txtSobrenome.Text;
                    funcionario.Cpf = txtCpf.Text;
                    funcionario.Rg = txtRg.Text;
                    funcionario.Profissao = txtProfissao.Text;
                    funcionario.Salario = Convert.ToDecimal(txtSalario.Text);
                    funcionario.caminhoFoto = caminhoFoto;
                    usuario.Acesso = acesso;

                    result = funcionarioDAO.inserirFuncionario(funcionario,usuario);//retorna o resultado da funcao

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

                    result = funcionarioDAO.alterarFuncionario(funcionario, usuario);

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
                        ptbEditar.Visible = false;
                    }

                }
                if (modo == "Excluir")
                {
                    int codigo = idFuncionario;

                    result = funcionarioDAO.excluirFuncionario(codigo);//recebe o resultado

                    if (result == true)
                    {
                        MessageBox.Show("Exclusão concluida com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparCampos();
                        desbloquearCampo();
                        carregarFunc();
                    }

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
            btnCarregar.Enabled = false;
            cmbAcesso.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)

        {
            modo = "Excluir";
            MessageBox.Show("Clique em gravar para continuar", "Clique para concluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnGravar.Enabled = true;
            ptbEditar.Visible = false;
            btnCarregar.Enabled = false;
            cmbAcesso.Enabled = false;
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

            caminhoFoto = "";

            if (openFile.ShowDialog() == DialogResult.OK)//se selecionar a foto, coloca o nome do arquivo na variável
            {
                modo = "alterarFoto";
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
            else
            {
                ptbFoto.Load(iconPadrao);
                btnGravar.Enabled = false;
                btnCadastrar.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                txtCpf.Enabled = false;
                txtPesquisar.Focus();
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

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
{
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }

        private void txtPrimeironome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)))//defini os caracteres somente letra
                e.Handled = true;
        }

        private void txtSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)))//defini os caracteres somente letra
                e.Handled = true;
        }
        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != ',') || (e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtSalario_MouseHover(object sender, EventArgs e)
        {
            lblSalario.Text = "Digite o salário com uma vírgula. Exemplo: 1000,0";
        }

        private void txtSalario_MouseLeave(object sender, EventArgs e)
        {
            lblSalario.Text = "";
        }

        private void cmbAcesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtPesquisar.Text;//parametro
            string img;

            dt = funcionarioDAO.selecionarFuncionario(cpf);//recebe o resultado

            if (txtPesquisar.Text.Length == 11)
            {
                if (modo == "Cadastrar")
                {
                    modo = "";
                    btnAlterar.Enabled = true;
                    btnCadastrar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnCarregar.Enabled = false;
                }

                if (dt.Rows.Count >= 1)//se linhas forem afetadas, carrega o dt
                {
                    lblMensagem.Text = "";
                    ptbEditar.Visible = true;
                    btnGravar.Enabled = true;
                    txtCpf.Enabled = false;
                    cmbAcesso.Enabled = true;

                    foreach (DataRow row in dt.Rows)
                    {
                        txtPrimeironome.Text = row["Nome"].ToString();
                        txtSobrenome.Text = row["Sobrenome"].ToString();
                        txtRg.Text = row["Rg"].ToString();
                        txtSalario.Text = row["Salário"].ToString();
                        txtCpf.Text = row["Cpf"].ToString();
                        txtProfissao.Text = row["Profissão"].ToString();
                        idFuncionario = row["Código"].GetHashCode();
                        acesso = row["idNivelAcesso"].GetHashCode();
                        cmbAcesso.Text = row["Nível"].ToString();
                        funcionario.foto = (byte[])row["Foto"];

                        using (var foto = new MemoryStream(funcionario.foto))//carrega a foto
                        {
                            ptbFoto.Image = Image.FromStream(foto);//adiciona a foto
                        }
                    }
                }
                else
                {
                    lblMensagem.Text = "Erro ao encontrar o cliente";
                    limparPesquisa();
                    ptbEditar.Visible = false;
                }
            }
            else
            {
                lblMensagem.Text = "";
                limparPesquisa();
                ptbEditar.Visible = false;
            }
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }
        private void txtProfissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)))//defini os caracteres somente letra
                e.Handled = true;
        }
        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            if (modo == "Cadastrar")
            {
                if (txtCpf.Text.Length == 11)
                {
                    if (txtCpf.Text.Length == 11 && txtRg.Text.Length == 11 || String.IsNullOrEmpty(txtRg.Text))
                    {
                        btnGravar.Enabled = true;
                    }
                }
                else
                {
                    btnGravar.Enabled = false;
                }
            }
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            if (modo == "Cadastrar")
            {
                if (txtCpf.Text.Length == 11 && txtRg.Text.Length == 11 || txtRg.Text == "" )
                {
                    btnGravar.Enabled = true;
                }
                else
                {
                    btnGravar.Enabled = false;
                }
            }
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }
    }
}
