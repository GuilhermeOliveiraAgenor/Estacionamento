using System;
using System.Windows.Forms;
using Model;
using Controller;
using System.Data;
using System.Collections.Generic;
using Estacionamento.Menu;
using Estacionamento.Login;
using Estacionamento.editarPedidos;
using Estacionamento.Saida;
using System.Runtime.InteropServices;

namespace Estacionamento.Entrada
{
    public partial class frmEntrada : Form
    {

        Estacionar estacionar = new Estacionar();
        EstacionarDAO estacionarDAO = new EstacionarDAO();
        clienteVeiculoDAO cliVeiculoDAO = new clienteVeiculoDAO();
        DateTime Entrada = new DateTime();
        int idCliente;
        int idVeiculo;
        int patio1;
        int patio2;
        public frmEntrada()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//maximizar a tela
        }
        public void verificar()
        {
            if (lblCodigodocliente.Text == "")
            {
                MessageBox.Show("Cpf não selecionado. Pesquisa na barra de pesquisa acima", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
            }
        }

        public void carregarGrid()
        {
            dgvCadastro.DataSource = estacionarDAO.carregarVeiculo();
       
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            dt1 = estacionarDAO.vagasPatio1();

            dt2 = estacionarDAO.vagasPatio2();

            if (dt1.Rows.Count <= 1 && dt2.Rows.Count <= 1)
            {
                foreach (DataRow row in dt1.Rows)
                {
                    lblPatio1.Text = row["Patio1"].ToString();
                }
                foreach (DataRow row1 in dt2.Rows)
                {
                    lblPatio2.Text = row1["Patio2"].ToString();
                }
            }

        }

        public void limparCampos()
        {
            cmbPatio.Text = "";
            cmbcodigoVeiculo.Text = "";
            lblCodigodocliente.Text = "";
            cmbcodigoVeiculo.Items.Clear();
            txtPesquisar.Clear();
            txtPesquisar.Focus();
        }
        public void configurarPesq()
        {
            lblCodigodocliente.Text = txtPesquisar.Text;//passa o cpf pesquisado para a label
            cmbcodigoVeiculo.Items.Clear();//limpa a combobox a cada pesquisa
            btnGravar.Enabled = true;
        }
        public void limparPesq()
        {
            txtPesquisar.Focus();
            lblCodigodocliente.Text = "";
            cmbcodigoVeiculo.Text = "";
            cmbPatio.Text = "";
            btnGravar.Enabled = false;//bloqueia o botão
            cmbcodigoVeiculo.Items.Clear();//limpa a combobox a cada pesquisa
        }

        public frmEntrada(string cpfPesquisa)
        {
            InitializeComponent();
            lblCodigodocliente.Text = cpfPesquisa;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//maximizar a tela
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            
            List<clienteVeiculo> veiculo = new List<clienteVeiculo>();
            string cpf = lblCodigodocliente.Text;//passa o parametros

            DataTable dt = new DataTable();
           
            carregarGrid();

            dt = cliVeiculoDAO.pesqCpf(cpf);//recebe o resultado

            veiculo = cliVeiculoDAO.listVeiculosCpf(cpf);

            if (dt.Rows.Count >= 1)
            {
                foreach (var item in veiculo)
                {
                    cmbcodigoVeiculo.Items.Add(item.Placa);//adiciona as placas do cliente
                }

            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bool result = false;
            Entrada = Convert.ToDateTime(DateTime.Now.ToString("F", System.Globalization.DateTimeFormatInfo.InvariantInfo));

            verificar();

            if (String.IsNullOrEmpty(cmbPatio.Text) || String.IsNullOrEmpty(cmbcodigoVeiculo.Text))//verificar campos vazios
            {
                MessageBox.Show("Selecione os itens", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                estacionar.Patio = Convert.ToInt32(cmbPatio.Text);//passa os parametros
                estacionar.dataEntrada = Entrada;
                estacionar.CodigoClienteVeiculo = Convert.ToInt32(cmbcodigoVeiculo.ValueMember);

                result = estacionarDAO.Entrada(estacionar);//recebe o resultado

                if (result == true)
                {
                    MessageBox.Show("Entrada realizada com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregarGrid();
                    limparCampos();
                    btnGravar.Enabled = false;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();//hora 
        }
        private void frmEntrada_DoubleClick(object sender, EventArgs e)
        {
            carregarGrid();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmVerificar frm = new frmVerificar();
            frm.Show();
            this.Hide();
        }

        private void btnCancelarfuncionario_Click(object sender, EventArgs e)
        {
            limparCampos();
            btnGravar.Enabled = false;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenuu().Show();
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

        private void cmbPatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbcodigoVeiculo_KeyPress(object sender, KeyPressEventArgs e)
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
            List<clienteVeiculo> veiculo = new List<clienteVeiculo>();
            string cpf = txtPesquisar.Text;//passa o parametros

            DataTable dt = new DataTable();

            cmbcodigoVeiculo.Text = "";
            cmbPatio.Text = "";

            dt = cliVeiculoDAO.pesqCpf(cpf);//recebe o resultado

            veiculo = cliVeiculoDAO.listVeiculosCpf(cpf);//recebe o resultado

            if (txtPesquisar.Text.Length == 11)
            {
                if (dt.Rows.Count >= 1)
                {
                    lblMensagem.Text = "";
                    configurarPesq();

                    dgvCadastro.DataSource = cliVeiculoDAO.pesqCpf(cpf);//carrega o grid

                    foreach (var item in veiculo)
                    {
                        cmbcodigoVeiculo.Items.Add(item.Placa);//adiciona as placas do cliente
                    }

                }
                else
                {
                    lblMensagem.Text = "Erro ao encontrar cliente";//mensagem de erro
                    limparPesq();
                    carregarGrid();
                }
            }
            else
            {
                lblMensagem.Text = "";
                limparPesq();
            }
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }
        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cmbcodigoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<clienteVeiculo> veiculos = new List<clienteVeiculo>();//lista de veiculos
            veiculos = cliVeiculoDAO.listarVeiculos();//recebe o resultado

            foreach (var item in veiculos)
            {
                if (cmbcodigoVeiculo.Text == item.Placa)//se o texto clicado for igual ao item da lista, retorna o id
                {
                    cmbcodigoVeiculo.ValueMember = item.IdClienteVeiculo.ToString();//recebe o id da combobox
                }

            }
        }
    }
}
