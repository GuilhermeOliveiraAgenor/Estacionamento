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

namespace Estacionamento.editarPedidos
{
    public partial class frmAlterarCliente : Form
    {
        Cliente cliente = new Cliente();
        ClienteDAO clienteDAO = new ClienteDAO();
        int idCliente;

        public frmAlterarCliente()
        {
            InitializeComponent();
        }

        public void carregarGrid()
        {
            DataTable dt = new DataTable();
            dgvClientes.DataSource = clienteDAO.carregarClientes();
        
        }
        private void frmAlterarCliente_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void btnPesquisarcodigo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string cpf = txtPesquisarcodigo.Text;//o cpf recebido
            bool result = false;

            dt = clienteDAO.PesqClienteCpf(cpf);//recebe o resultado

            if (dt.Rows.Count >= 1)//se encontrar resultados, preenche os texts
            {
                foreach ( DataRow row in dt.Rows)
                {
                    txtCliente.Text = row["Nome"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    idCliente = Convert.ToInt32(row["idCliente"].ToString());
                }
                txtPesquisarcodigo.Clear();
            }
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Erro ao encontrar cpf", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
                txtPesquisarcodigo.Focus();
            }
        }

        private void btnAlterarcliente_Click(object sender, EventArgs e)
        {
            bool result = false;

            cliente.Nome = txtCliente.Text;//parametros
            cliente.Email = txtEmail.Text;
            cliente.idCliente = idCliente;

            result = clienteDAO.editarCliente(cliente);//recebe o resultado

            if (result == true)
            {
                MessageBox.Show("Concluido com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            int linha;

            linha = dgvClientes.CurrentRow.Index;
            txtCliente.Text = dgvClientes[1, linha].Value.ToString();
            txtEmail.Text = dgvClientes[3, linha].Value.ToString();
            idCliente = dgvClientes[0, linha].Value.GetHashCode();

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisarnome.Text;//nome que vai ser pesquisado
            DataTable dt = new DataTable();

            dt = clienteDAO.PesqClienteNome(nome);//recebe o resultado

            if (dt.Rows.Count >= 1)
            {
                dgvClientes.DataSource = clienteDAO.PesqClienteNome(nome);//informações no grid
                txtPesquisarnome.Clear();
            }
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Erro ao encontrar nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
                txtPesquisarnome.Focus();
            }

        }

        private void frmAlterarCliente_DoubleClick(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void btnVoltaraomenu_Click(object sender, EventArgs e)
        {
            frmMenuu frm = new frmMenuu();
            frm.Show();
            this.Hide();
        }
    }
}
