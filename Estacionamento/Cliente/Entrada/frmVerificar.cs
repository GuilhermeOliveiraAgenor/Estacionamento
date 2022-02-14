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
using Estacionamento.Login;
using Estacionamento.Menu;
using Estacionamento.editarPedidos;
using Estacionamento.Saida;

namespace Estacionamento.Entrada
{
    public partial class frmVerificar : Form
    {

        Cliente cliente = new Cliente();
        ClienteDAO clienteDAO = new ClienteDAO();
        EstacionarDAO estacionarDAO = new EstacionarDAO();
        int patio1;
        int patio2;
        public frmVerificar()
        {
            InitializeComponent();
        }

        public void irMenu(){

            frmMenuu menu = new frmMenuu();
            menu.Show();
            this.Hide();

        }
        public void irEntrada()
        {
            frmEntrada frmentrada = new frmEntrada();
            frmentrada.Show();
            this.Hide();
        }
        public void irCadastro()
        {
            frmCadCliente cadCliente = new frmCadCliente();
            cadCliente.Show();
            this.Hide();

        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            irCadastro();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            irEntrada();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
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
        private void btnCodigo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //passar parametros
            string cpf = txtCpf.Text;

            dt = clienteDAO.PesqClienteCpf(cpf);//recebe o resultado do datatable

            if (dt.Rows.Count == 1)
            {
                frmEntrada frmentrada = new frmEntrada(txtCpf.Text);//vai para a tela de entrada
                frmentrada.Show();
                this.Hide();

            }
            if (dt.Rows.Count < 1)
            {
                DialogResult dr = MessageBox.Show("Erro ao encontrar cliente. Deseja cadastrar ?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    irCadastro();//vai para tela de cadastrar cliente
                }
                if (dr == DialogResult.No)
                {
                    txtCpf.Focus();
                }

            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }
    }
}
