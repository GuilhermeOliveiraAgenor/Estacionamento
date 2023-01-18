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
    public partial class frmEditarEstacionar : Form
    {
        Estacionar estacionar = new Estacionar();
        EstacionarDAO estacionarDAO = new EstacionarDAO();
        clienteVeiculoDAO cliVeiculoDAO = new clienteVeiculoDAO();
        List<clienteVeiculo> cliVeiculo = new List<clienteVeiculo>();
        DataTable dt = new DataTable();
        int idEstacionar;
        string modo;
        int idClienteVeiculo;
        int patio1;
        int patio2;
        public frmEditarEstacionar()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//maximizar a tela
        }
        public void desbloquearCampo()
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnGravar.Enabled = true;
        }
        public void vagasOcupadas()
        {
            dgvEstacionar.DataSource = estacionarDAO.carregarVeiculo();
            dgvEstacionar.Refresh();

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            dt1 = estacionarDAO.vagasPatio1();//recebe o resultado

            dt2 = estacionarDAO.vagasPatio2();

            if (dt1.Rows.Count >= 1 && dt2.Rows.Count >= 1)//se linhas forem afetadas
            {
                foreach (DataRow row in dt1.Rows)
                {
                    lblPatio1.Text = row["Patio1"].ToString();//carrega as informações
                }
                foreach (DataRow row in dt2.Rows)
                {
                    lblPatio2.Text = row["Patio2"].ToString();
                }
            }
        }
        public void irMenu()
        {
            new frmMenuu().Show();
            this.Hide();
        }

        public void limparCampos()
        {
            lblData.Text = "";
            cmbPatio.Text = "";
            cmbPlaca.Text = "";
            lblMensagem.Text = "";
            cmbPlaca.Items.Clear();
            txtPesquisar.Clear();
            idClienteVeiculo = 0;
            idEstacionar = 0;
        }

        public void limparPesquisa()
        {
            lblData.Text = "";
            cmbPatio.Text = "";
            cmbPlaca.Text = "";
            lblData.Text = "";
            cmbPlaca.Items.Clear();
            idClienteVeiculo = 0;
            idEstacionar = 0;
        }

        private void frmAlterarEstacionar_Load(object sender, EventArgs e)
        {
            vagasOcupadas();

        }
        private void cmbcodigoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliVeiculo = cliVeiculoDAO.listarVeiculos();//recebe o resultado

            foreach (var item in cliVeiculo)
            {
                if (cmbPlaca.Text == item.Placa)//se o text for igual ao item selecionado, retorna id
                {
                    cmbPlaca.ValueMember = item.IdClienteVeiculo.ToString();//recebe o id da combobox
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            irMenu();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            modo = "excluir";//coloca modo excluir
            MessageBox.Show("Clique em gravar para continuar", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAlterar.Enabled = false;
            btnGravar.Enabled = true;
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {

            bool result = false;

            if (modo == "alterar")
            {
                if (String.IsNullOrEmpty(cmbPatio.Text) || String.IsNullOrEmpty(cmbPlaca.Text) || idClienteVeiculo == 0 || idEstacionar == 0)//campos vazios
                {
                    MessageBox.Show("Preencha os campos ou selecione novamente o cliente","Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    estacionar.idEstacionar = idEstacionar;
                    estacionar.Patio = Convert.ToInt32(cmbPatio.Text);//parametro
                    estacionar.CodigoClienteVeiculo = idClienteVeiculo;

                    result = estacionarDAO.alterarEstacionar(estacionar);//recebe o resultado

                    if (result == true)
                    {
                        MessageBox.Show("Alteração concluída", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vagasOcupadas();
                        limparCampos();
                        btnExcluir.Enabled = true;
                        btnGravar.Enabled = false;
                    }
                }
            }

            if (modo == "excluir")
            {
                int codigo = idEstacionar;

                if (idEstacionar == 0)//campos vazios
                {
                    MessageBox.Show("Pesquise novamente", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    result = estacionarDAO.excluirEstacionar(idEstacionar);

                    if (result == true)
                    {
                        MessageBox.Show("Exclusão concluída", "Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vagasOcupadas();
                        limparCampos();
                        btnAlterar.Enabled = true;
                        btnGravar.Enabled = false;
                    }
                    
                    if (result == false)
                    {
                        MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
        private void btnVoltaraomenu_Click(object sender, EventArgs e)
        {
            frmMenuu frm = new frmMenuu();
            frm.Show();
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

        private void entradaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmVerificar().Show();
            this.Hide();
        }

        private void saídaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmSaida().Show();
            this.Hide();
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmEditarEstacionar().Show();
            this.Hide();
        }
        private void veiculoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmInserirVeiculo().Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmMenuu().Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fecharToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loginUsuario.logout();
            new frmLogin().Show();
            this.Hide();
        }
        private void frmAlterarEstacionar_DoubleClick(object sender, EventArgs e)
        {
            vagasOcupadas();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            modo = "alterar";//coloca a variavel em alterar
            MessageBox.Show("Clique em gravar para continuar", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnExcluir.Enabled = false;
            btnGravar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            vagasOcupadas();
            btnGravar.Enabled = false;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
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

        private void cmbPlaca_KeyPress(object sender, KeyPressEventArgs e)
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

            cmbPatio.Text = "";
            cmbPlaca.Text = "";

            dt = estacionarDAO.PesqCpfOcupados(cpf);//recebe o resultado

            cliVeiculo = cliVeiculoDAO.listVeiculosCpf(cpf);

            if (txtPesquisar.Text.Length == 11)
            {
                if (dt.Rows.Count == 1)
                {
                    cmbPlaca.Items.Clear();//limpa o combobox
                    lblMensagem.Text = "";
    
                foreach (DataRow row in dt.Rows)
                    {
                        lblData.Text = row["Entrada"].ToString();//passa as informaçoes
                        cmbPatio.Text = row["Pátio"].ToString();
                        cmbPlaca.Text = row["Placa"].ToString();
                        idEstacionar = Convert.ToInt32(row["Código"].GetHashCode());
                    }
                    foreach (var item in cliVeiculo)
                    {
                        cmbPlaca.Items.Add(item.Placa);//adiciona na combobox
                    }

                    dgvEstacionar.DataSource = estacionarDAO.PesqCpfOcupados(cpf);

                }
                if (dt.Rows.Count < 1)
                {
                    lblMensagem.Text = "Erro ao encontrar cliente";//mensagem de erro
                    vagasOcupadas();
                    limparPesquisa();
                }
            }
            
            else
            {
                lblMensagem.Text = "";
                limparPesquisa();
            }



        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }
        private void cmbPlaca_TextChanged(object sender, EventArgs e)
        {
            List<clienteVeiculo> cliVeiculo = cliVeiculoDAO.listarVeiculos();

            foreach (var item in cliVeiculo)
            {
                if (cmbPlaca.Text == item.Placa)
                {
                    idClienteVeiculo = item.IdClienteVeiculo.GetHashCode();
                }
            }
        }

    }
}
