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
            cmbcodVeiculo.Text = "";
        }
    
        //TODO: Cadastro de clientes e veículos - tela
        
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

            cliente.Nome = txtNomee.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Email = txtEmail.Text;
            cliveiculo.codigo_Veiculo = Convert.ToInt32(cmbcodVeiculo.ValueMember);
            cliveiculo.Placa = txtPlaca.Text;

            result = cliveiculoDAO.InserirClienteVeiculo(cliente, cliveiculo);//recebe o resultado

            if (result == true)
            {
                MessageBox.Show("Cadastro Concluido", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);//mensagem de erro
                frmEntrada frm = new frmEntrada(txtCpf.Text);
                frm.Show();
                this.Hide();
            }

        }

        private void btnPesquisarnome_Click(object sender, EventArgs e)
        {
            string placa = txtPesquisarplaca.Text;

            dt = cliveiculoDAO.pesqPlaca(placa);//recebe o resultado

            if (dt.Rows.Count >= 1)
            {
                dgvCadastro.DataSource = cliveiculoDAO.pesqPlaca(placa);//carrega no grid
                dgvCadastro.Refresh();
                txtPesquisarplaca.Clear();
            }
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Nenhum registro encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
                txtPesquisarplaca.Focus();
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string cpf = txtPesquisarcodigo.Text;//parametro

            dt = clienteDAO.PesqClienteCpf(cpf);//recebe o resultado da pesquisa

            if (dt.Rows.Count == 1)//se linhas forem afetadas, carrega o grid
            {
                dgvCadastro.DataSource = clienteDAO.PesqClienteCpf(cpf);//carrega o grid
                dgvCadastro.Refresh();
                txtPesquisarcodigo.Clear();
            }
            if (dt.Rows.Count < 1)//se não afetar linhas, retorna erro
            {
                MessageBox.Show("Nenhum registro encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
                txtPesquisarcodigo.Focus();
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

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void lblRg_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltaraomenu_Click(object sender, EventArgs e)
        {
            frmMenuu frm = new frmMenuu();
            frm.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
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
                MessageBox.Show("As vagas no patio 1 são: " + patio1 +"\n" + "E no patio 2 são: " + patio2,"Vagas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAlterarCliente().Show();
            this.Hide();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInserirCliveiculo().Show();
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

    }
}
