using Controller;
using DAO;
using Estacionamento.editarPedidos;
using Estacionamento.Entrada;
using Estacionamento.Login;
using Estacionamento.Saida;
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

namespace Estacionamento.Menu
{
    public partial class frmMenuu : Form

    {
        EstacionarDAO estacionarDAO = new EstacionarDAO();
        clienteVeiculoDAO cliveiculoDAO = new clienteVeiculoDAO();
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
        public void vagasOcupadas()
        {
            
        }
        public frmMenuu()
        {
            InitializeComponent();
        }
        //TODO: Menu - tela e criar tela alterar dados do usuário logado
        private void frmMenuu_Load(object sender, EventArgs e)
        {
            string cpf = loginUsuario.getCpf();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            dt = estacionarDAO.vagasPatio1();//recebe o resultado

            dt1 = estacionarDAO.vagasPatio2();

            dt2 = funcionarioDAO.selecionarFuncionario(cpf);

            if (dt.Rows.Count <= 1 && dt1.Rows.Count <= 1)//se linhas forem afetadas, carrega as informaçoes
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblPatio1.Text = row["Patio1"].ToString();//carrega a informaçao
                }
                foreach (DataRow row1 in dt1.Rows)
                {
                    lblPatio2.Text = row1["Patio2"].ToString();
                }
            }
            if (dt2.Rows.Count >= 1)//se linhas forem afetadas, carrega a informaçao
            {
                foreach(DataRow row in dt2.Rows)
                {
                    lblNome.Text = row["primeiroNome"].ToString();
                    lblCpf.Text = row["Cpf"].ToString();
                }
            }

            vagasOcupadas();

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            frmVerificar frm = new frmVerificar();
            frm.Show();
            this.Hide();
        }

        private void btnVoltarmenu_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
            this.Hide();
        }

        private void btnSaída_Click(object sender, EventArgs e)
        {
            frmSaida frm = new frmSaida();
            frm.Show();
            this.Hide();

            //TODO: Fazer saida - tela
        }

        private void btnAlterarveiculo_Click(object sender, EventArgs e)
        {
            frmInserirCliveiculo frm = new frmInserirCliveiculo();
            frm.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            dgvVeiculos.DataSource = estacionarDAO.veiculosHoje();
            dgvVeiculos.Refresh();
        }

        private void frmMenuu_DoubleClick(object sender, EventArgs e)
        {
            vagasOcupadas();
        }

        private void btnVagas_Click(object sender, EventArgs e)
        {
            vagasOcupadas();
        }

        private void btnNotificação_Click(object sender, EventArgs e)
        {

        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvVeiculos.DataSource = cliveiculoDAO.CarregarClienteVeiculo();
            dgvVeiculos.Refresh();
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string placa = txtPesquisarplaca.Text;//recebe os parametros

            dt = estacionarDAO.pesqPlaca(placa);//recebe o resultado

            if (dt.Rows.Count >= 1)//se as linhas forem afetadas, carrega o grid
            {
                dgvVeiculos.DataSource = estacionarDAO.pesqPlaca(placa);
                dgvVeiculos.Refresh();
                txtPesquisarplaca.Clear();
            }
            if (dt.Rows.Count < 1)//se linhas nao forem afetadas
            {
                MessageBox.Show("Erro ao encontrar placa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
                txtPesquisarplaca.Focus();
            }
        }

        private void btnCpf_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string cpf = txtCpf.Text;//passa o parametro

            dt = estacionarDAO.pesqCpf(cpf);//recebe o resultado

            if (dt.Rows.Count >= 1)
            {
                dgvVeiculos.DataSource = estacionarDAO.pesqCpf(cpf);//carrega o grid
                dgvVeiculos.Refresh();
                txtCpf.Clear();
            }
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Erro ao encontrar cpf", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
                txtCpf.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void ptbMapa_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.waze.com/pt-BR/live-map/directions?utm_source=waze_website&utm_campaign=waze_website&utm_medium=website_menu&from=place.Ej1QcmHDp2EgUnVpIEJhcmJvc2EgLSBDZW50cm8sIEN1cml0aWJhIC0gUFIsIDgyODYwLTE0MCwgQnJhemlsIi4qLAoUChIJ1fIR-23k3JQRJ-n38nhlHY0SFAoSCRtrbERs5NyUEXsUB92w5Q0N");
            //vai para o link
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmAlterarCliente frm = new frmAlterarCliente();
            frm.Show();
            this.Hide();
        }

        private void btnSairmenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlterarpedido_Click(object sender, EventArgs e)
        {
            frmAlterarEstacionar frm = new frmAlterarEstacionar();
            frm.Show();
            this.Hide();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmAlterarEstacionar frm = new frmAlterarEstacionar();
            frm.Show();
            this.Hide();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {

           decimal Valor;
           TimeSpan Hora = Convert.ToDateTime(txtHora.Text).TimeOfDay;//recebe o parametro
           decimal Minutos = Convert.ToDecimal(Hora.TotalMinutes.ToString());//converte para minutos

            Valor = (Minutos * 15) / 100;

            Valor = Math.Round(Valor, 2);//passa o valor e defini quantas casas decimais

            lblPreco.Text = Valor.ToString();//o valor vai para o text
                      
        }
    }
}
