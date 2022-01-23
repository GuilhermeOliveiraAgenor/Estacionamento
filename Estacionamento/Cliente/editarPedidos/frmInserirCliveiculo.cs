using Controller;
using Estacionamento.Menu;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.editarPedidos
{
    public partial class frmInserirCliveiculo : Form
    {
        clienteVeiculo cliveiculo = new clienteVeiculo();
        clienteVeiculoDAO cliveiculoDAO = new clienteVeiculoDAO();
        Veiculo veiculo = new Veiculo();
        VeiculoDAO veiculoDAO = new VeiculoDAO();
        Cliente cliente = new Cliente();

        public frmInserirCliveiculo()
        {
            InitializeComponent();
        }

        public void carregarGrid()
        {

            dgvVeiculos.DataSource = cliveiculoDAO.CarregarClienteVeiculo();//carrega o grid
            dgvVeiculos.Refresh();
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

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            string cpf = txtPesquisar.Text;//parametro
            DataTable dt = new DataTable();

            dt = cliveiculoDAO.pesqCpf(cpf);//recebe o resultado

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvVeiculos.DataSource = cliveiculoDAO.pesqCpf(cpf);//carrega no grid
                }
                txtPesquisar.Clear();
            }
            if (dt.Rows.Count < 1)
            {

                MessageBox.Show("Cpf não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
                txtPesquisar.Focus();
            }

        }

        private void btnCadastrarveiculo_Click(object sender, EventArgs e)
        {
            bool result = false;

            cliveiculo.codigo_Veiculo = Convert.ToInt32(cmbVeiculo.ValueMember);//parametros
            cliveiculo.Placa = txtPlaca.Text;
            cliente.Cpf = txtCodigocliente.Text;

            result = cliveiculoDAO.inserirVeiculocv(cliveiculo, cliente);//recebe o resultado

            if (result == true)
            {
                MessageBox.Show("Cadastro concluido", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            frmMenuu frm = new frmMenuu();
            frm.Show();
            this.Hide();
        }
    }
}
