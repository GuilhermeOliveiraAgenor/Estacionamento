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
using Estacionamento.Saida;
using Estacionamento.editarPedidos;
using Estacionamento.Login;
using System.Runtime.InteropServices;

namespace Estacionamento.Entrada
{
    public partial class frmCadCliente : Form
    {
        Cliente cliente = new Cliente();
        clienteVeiculo cliveiculo = new clienteVeiculo();
        ClienteDAO clienteDAO = new ClienteDAO();
        VeiculoDAO veiculoDAO = new VeiculoDAO();
        clienteVeiculoDAO cliveiculoDAO = new clienteVeiculoDAO();
        EstacionarDAO estacionarDAO = new EstacionarDAO();
        DataTable dt = new DataTable();
        int patio1;
        int patio2;
        public frmCadCliente()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//maximizar a tela
        }
        public frmCadCliente(string cpf)
        {
            InitializeComponent();
            txtCpf.Text = cpf;
        }
        public void carregarGrid(){

            dgvCadastro.DataSource = cliveiculoDAO.CarregarClienteVeiculo();//carrega o grid
            dgvCadastro.Refresh();
        }

        public void limparCampos()
        {
            txtNomee.Clear();
            txtPlaca.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            btnCadastrar.Enabled = true;
            txtPesquisarcodigo.Clear();
            txtPesquisarplaca.Clear();
            cmbcodVeiculo.Text = "";
        }
        
        public void validarCampos()
        {
            if (txtCpf.Text.Length == 11 && txtPlaca.Text.Length == 7)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }
       
        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            List<Veiculo> veiculos = veiculoDAO.carregarVeiculo();//recebe o resultado

            foreach (var item in veiculos)
            {
                cmbcodVeiculo.Items.Add(item.descricaoVeiculo);//adiciona na combobox
            }

            carregarGrid();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {       
            bool result = false;

            //parametros

            if (String.IsNullOrEmpty(txtNomee.Text) || String.IsNullOrEmpty(txtCpf.Text) || String.IsNullOrEmpty(txtEmail.Text)//verificar campos vazios
                || String.IsNullOrEmpty(txtPlaca.Text) || String.IsNullOrEmpty(cmbcodVeiculo.ValueMember))
            {
                MessageBox.Show("Preencha os campos", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                cliente.Nome = txtNomee.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Email = txtEmail.Text;
                cliveiculo.codigo_Veiculo = Convert.ToInt32(cmbcodVeiculo.ValueMember);
                cliveiculo.Placa = txtPlaca.Text.ToUpper();

                result = cliveiculoDAO.InserirClienteVeiculo(cliente, cliveiculo);//recebe o resultado

                if (result == true)
                {
                    MessageBox.Show("Cadastro Concluido", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);//mensagem de erro
                    carregarGrid();
                    limparCampos();
                    frmEntrada frm = new frmEntrada(cliente.Cpf);
                    frm.Show();
                    this.Hide();
                }
            }

        }
        private void cmbcodVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Veiculo> veiculos = veiculoDAO.carregarVeiculo();//recebe o resultado

            foreach (var item in veiculos)
            {
                if (cmbcodVeiculo.Text == item.descricaoVeiculo)//se o texto selecionado for igual, retorna o id
                {
                    cmbcodVeiculo.ValueMember = item.idVeiculo.ToString();//recebe o id da combobox
                }
            }
           
        }

        private void frmCadCliente_DoubleClick(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void btnVoltaraomenu_Click(object sender, EventArgs e)
        {
            new frmMenuu().Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            carregarGrid();
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
                MessageBox.Show("As vagas no patio 1 são: " + patio1 +"\n" + "E no patio 2 são: " + patio2,"Vagas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInserirVeiculo().Show();
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

        private void txtPesquisarcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }

        private void txtPesquisarplaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres numero e letra
                e.Handled = true;
        }
        private void txtNomee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)))//defini os caracteres somente letra
                e.Handled = true;
        }
        private void cmbcodVeiculo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPesquisarcodigo_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtPesquisarcodigo.Text;//parametro

            dt = cliveiculoDAO.pesqCpf(cpf);//recebe o resultado da pesquisa

            if (txtPesquisarcodigo.Text.Length == 11)
            {
                lblMensagem.Text = "";
                if (dt.Rows.Count >= 1)//se linhas forem afetadas, carrega o grid
                {
                    dgvCadastro.DataSource = cliveiculoDAO.pesqCpf(cpf);//carrega o grid
                }
                else//se não afetar linhas, retorna erro
                {
                    lblMensagem.Text = "Erro ao encontrar o cliente";
                    txtPesquisarcodigo.Focus();
                    carregarGrid();
                }
            }
            else
            {
                lblMensagem.Text = "";
            }
        }

        private void txtPesquisarcodigo_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }

        private void txtPesquisarplaca_TextChanged(object sender, EventArgs e)
        {
            string placa = txtPesquisarplaca.Text.ToUpper();

            dt = cliveiculoDAO.pesqPlaca(placa);//recebe o resultado

            if (txtPesquisarplaca.Text.Length == 7)
            {
                lblMensagem.Text = "";
                if (dt.Rows.Count >= 1)
                {
                    dgvCadastro.DataSource = cliveiculoDAO.pesqPlaca(placa);//carrega no grid
                }
                else
                {
                    lblMensagem.Text = "Erro ao encontrar cliente";//mensagem de erro
                    txtPesquisarplaca.Focus();
                    carregarGrid();
                }
            }
            else
            {
                lblMensagem.Text = "";
            }
        }

        private void txtPesquisarplaca_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }

      

       private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres numero e letra
                e.Handled = true;
        }
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
        if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
            e.Handled = true;
        }
    }
}
