using Controller;
using Estacionamento.Entrada;
using Estacionamento.Login;
using Estacionamento.Menu;
using Estacionamento.Saida;
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

namespace Estacionamento.editarPedidos
{
    public partial class frmInserirVeiculo : Form
    {
        clienteVeiculo cliveiculo = new clienteVeiculo();
        clienteVeiculoDAO cliveiculoDAO = new clienteVeiculoDAO();
        Veiculo veiculo = new Veiculo();
        VeiculoDAO veiculoDAO = new VeiculoDAO();
        Cliente cliente = new Cliente();
        EstacionarDAO estacionarDAO = new EstacionarDAO();
        int patio1;
        int patio2;

        public frmInserirVeiculo()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//maximizar a tela
        }
        public void carregarGrid()
        {

            dgvVeiculos.DataSource = cliveiculoDAO.CarregarClienteVeiculo();//carrega o grid
            dgvVeiculos.Refresh();
        }

        public void limparCampos()
        {
            txtCpf.Clear();
            cmbVeiculo.Text = "";
            txtPlaca.Clear();
            txtPesquisar.Clear();
            btnCadastrarveiculo.Enabled = true;
        }
        public void limparPesquisa()
        {
            txtCpf.Clear();
            cmbVeiculo.Text = "";
            txtPlaca.Clear();
            btnCadastrarveiculo.Enabled = true;
        }
        public void validarCampos()
        {
            if (txtCpf.Text.Length == 11 && txtPlaca.Text.Length == 7)
            {
                btnCadastrarveiculo.Enabled = true;
            }
            else
            {
                btnCadastrarveiculo.Enabled = false;
            }
        }

        private void frmInserirCliveiculo_Load(object sender, EventArgs e)
        {
            List<Veiculo> veiculos = veiculoDAO.carregarVeiculo();//recebe o resultado

            foreach (var item in veiculos)
            {
                cmbVeiculo.Items.Add(item.descricaoVeiculo);//carrega na combobox
            }

            carregarGrid();

        }
        private void btnCadastrarveiculo_Click(object sender, EventArgs e)
        {
            bool result = false;

            if (String.IsNullOrEmpty(txtCpf.Text) || String.IsNullOrEmpty(txtPlaca.Text) || String.IsNullOrEmpty(cmbVeiculo.ValueMember))//verificar campos vazios
            {
                MessageBox.Show("Preencha os campos", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cliveiculo.codigo_Veiculo = Convert.ToInt32(cmbVeiculo.ValueMember);//parametros
                cliveiculo.Placa = txtPlaca.Text.ToUpper();
                cliente.Cpf = txtCpf.Text;

                result = cliveiculoDAO.inserirVeiculocv(cliveiculo, cliente);//recebe o resultado

                if (result == true)
                {
                    MessageBox.Show("Cadastro concluido", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregarGrid();
                    limparCampos();
                }
            }   
        }

        private void cmbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            veiculos = veiculoDAO.carregarVeiculo();//recebe o resultado

            foreach (var item in veiculos)
            {
                if (cmbVeiculo.Text == item.descricaoVeiculo)
                {
                    cmbVeiculo.ValueMember = item.idVeiculo.ToString();//recebe o id da combobox
                }
            }

        }

        private void frmInserirCliveiculo_DoubleClick(object sender, EventArgs e)
        {
            carregarGrid();
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
        private void btnCancelarfuncionario_Click(object sender, EventArgs e)
        {
            limparCampos();
            carregarGrid();
        }
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }
        private void cmbVeiculo_KeyPress(object sender, KeyPressEventArgs e)
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
            DataTable dt = new DataTable();

            dt = cliveiculoDAO.pesqCpf(cpf);//recebe o resultado

            if (txtPesquisar.Text.Length == 11)
            {
                lblMensagem.Text = "";
                if (dt.Rows.Count >= 1)
                {
                    dgvVeiculos.DataSource = cliveiculoDAO.pesqCpf(cpf);//carrega no grid
                }
                else
                {
                    lblMensagem.Text = "Erro ao encontrar o cliente";
                    txtPesquisar.Focus();
                    carregarGrid();
                }
            }
            else
            {
                lblMensagem.Text = "";
            }
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }
        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres numero e letra
                e.Handled = true;
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            carregarGrid();
        }
    }
}

