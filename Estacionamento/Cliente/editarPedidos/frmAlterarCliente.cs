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
using Estacionamento.Login;
using Estacionamento.Saida;
using Estacionamento.Entrada;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Estacionamento.editarPedidos
{
    public partial class frmAlterarCliente : Form
    {
        Cliente cliente = new Cliente();
        ClienteDAO clienteDAO = new ClienteDAO();
        EstacionarDAO estacionarDAO = new EstacionarDAO();
        int idCliente;
        int patio1;
        int patio2;
        public frmAlterarCliente()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//maximizar a tela
        }
        public void carregarGrid()
        {
            DataTable dt = new DataTable();
            dgvClientes.DataSource = clienteDAO.carregarClientes();

        }

        public void limparCampos()
        {
            txtCliente.Clear();
            txtEmail.Clear();
            txtPesquisarnome.Clear();
            txtPesquisarcodigo.Clear();
            lblCpf.Text = "";
            idCliente = 0;
            dgvClientes.Enabled = true;
        }

        public void limparPesquisa()
        {
            txtCliente.Clear();
            txtEmail.Clear();
            lblCpf.Text = "";
            idCliente = 0;
            dgvClientes.Enabled = true;
        }
        private void frmAlterarCliente_Load(object sender, EventArgs e)
        {
            carregarGrid();
            txtPesquisarcodigo.Focus();
        }

        public void bloquearBotao()
        {
            btnAlterarcliente.Enabled = false;
        }
        public void desbloquearBotao()
        {
            btnAlterarcliente.Enabled = true;
        }   
        private void btnAlterarcliente_Click(object sender, EventArgs e)
        {
            bool result = false;

            if (String.IsNullOrEmpty(txtCliente.Text) || String.IsNullOrEmpty(txtEmail.Text) || idCliente == 0)//verificar campos vazios
            {
                MessageBox.Show("Preencha os campos ou selecione o cliente novamente", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                cliente.Nome = txtCliente.Text;//parametros
                cliente.Email = txtEmail.Text;
                cliente.idCliente = idCliente;

                result = clienteDAO.editarCliente(cliente);//recebe o resultado

                if (result == true)
                {
                    MessageBox.Show("Concluído com sucesso", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregarGrid();
                    limparCampos();
                }
            }

        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            int linha;

            linha = dgvClientes.CurrentRow.Index;
            txtCliente.Text = dgvClientes[1, linha].Value.ToString();
            lblCpf.Text = dgvClientes[2, linha].Value.ToString();
            txtEmail.Text = dgvClientes[3, linha].Value.ToString();
            idCliente = dgvClientes[0, linha].Value.GetHashCode();

        }
        private void frmAlterarCliente_DoubleClick(object sender, EventArgs e)
        {
            carregarGrid();
            limparCampos();
        }

        private void btnVoltaraomenu_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)))//defini os caracteres somente letra
                e.Handled = true;
        }
        private void txtPesquisarnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)))//defini os caracteres somente letra
                e.Handled = true;
        }

        private void txtPesquisarcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInserirVeiculo().Show();
            this.Hide();
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
            if (txtPesquisarcodigo.Text.Length == 11)
            {
                DataTable dt = new DataTable();
                string cpf = txtPesquisarcodigo.Text;//o cpf recebido

                dt = clienteDAO.PesqClienteCpf(cpf);//recebe o resultado

                if (dt.Rows.Count == 1)//se encontrar resultados, preenche os texts
                {
                    lblCpf.Text = txtPesquisarcodigo.Text;
                    foreach (DataRow row in dt.Rows)
                    {
                        txtCliente.Text = row["Nome"].ToString();
                        txtEmail.Text = row["Email"].ToString();
                        idCliente = Convert.ToInt32(row["Código"].ToString());
                    }

                    dgvClientes.Enabled = false;
                }
                else
                {
                    lblMensagem.Text = "Erro ao encontrar cpf";
                    txtPesquisarcodigo.Focus();
                    carregarGrid();
                    limparPesquisa();
                }
            }
            else
            {
                lblMensagem.Text = ""; 
                limparPesquisa();
            }

        }

        private void txtPesquisarnome_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarnome.Text.Length >= 1)
            {
                string nome = txtPesquisarnome.Text;//nome que vai ser pesquisado
                DataTable dt = new DataTable();

                dt = clienteDAO.PesqClienteNome(nome);//recebe o resultado


                if (dt.Rows.Count >= 1)
                {
                    dgvClientes.DataSource = clienteDAO.PesqClienteNome(nome);//informações no grid
                    dgvClientes.Enabled = true;
                }
                else
                {
                    lblMensagem.Text = "Erro ao encontrar cliente";
                    txtPesquisarnome.Focus();
                    carregarGrid();
                    limparPesquisa();
                }
            }
            else
            {
                lblMensagem.Text = "";
                limparPesquisa();
            }
        }

        private void txtPesquisarcodigo_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }

        private void txtPesquisarnome_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }
    }
}
