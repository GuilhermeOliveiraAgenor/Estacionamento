using Controller;
using DAO;
using Estacionamento.editarPedidos;
using Estacionamento.Entrada;
using Estacionamento.Funcionario.Relatorio;
using Estacionamento.Login;
using Estacionamento.Saida;
using Estacionamento.Usuarios;
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
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            dt = estacionarDAO.vagasPatio1();//recebe o resultado

            dt1 = estacionarDAO.vagasPatio2();

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

            dgvVeiculos.DataSource = estacionarDAO.carregarVeiculo();
            dgvVeiculos.Refresh();
        }
        public frmMenuu()
        {
            InitializeComponent();
        }

        //TODO: Menu - tela, conferir codigos abertos e excluir, excluir código de botao pesquisar, id existe ou nao procedure e colocar mask

        private void frmMenuu_Load(object sender, EventArgs e)
        {
            string cpf = loginUsuario.getCpf();

            DataTable dt2 = new DataTable();

            dt2 = funcionarioDAO.selecionarFuncionario(cpf);

            if (dt2.Rows.Count >= 1)//se linhas forem afetadas, carrega a informaçao
            {
                foreach(DataRow row in dt2.Rows)
                {
                    lblNome.Text = row["Nome"].ToString();            
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
            frmInserirVeiculo frm = new frmInserirVeiculo();
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
        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvVeiculos.DataSource = cliveiculoDAO.CarregarClienteVeiculo();
            dgvVeiculos.Refresh();
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string placa = txtPesquisarplaca.Text.ToUpper();//recebe os parametros

            dt = estacionarDAO.pesqPlaca(placa);//recebe o resultado

            if (dt.Rows.Count >= 1)//se as linhas forem afetadas, carrega o grid
            {
                dgvVeiculos.DataSource = estacionarDAO.pesqPlaca(placa);
                dgvVeiculos.Refresh();
            }
            else//se linhas nao forem afetadas
            {
                MessageBox.Show("Erro ao encontrar placa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
                txtPesquisarplaca.Focus();
                vagasOcupadas();
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
            }
            else
            {
                MessageBox.Show("Erro ao encontrar cpf", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
                txtCpf.Focus();
                vagasOcupadas();
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
            frmEditarEstacionar frm = new frmEditarEstacionar();
            frm.Show();
            this.Hide();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FrmEditarFuncionario frm = new FrmEditarFuncionario();
            frm.Show();
            this.Hide();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            decimal Valor;
            TimeSpan Hora = Convert.ToDateTime(mskHora.Text).TimeOfDay;//recebe o parametro
            decimal Minutos = Convert.ToDecimal(Hora.TotalMinutes.ToString());//converte para minutos

            Valor = (Minutos * 15) / 100;

            Valor = Math.Round(Valor, 2);//passa o valor e defini quantas casas decimais

            lblPreco.Text = Valor.ToString();//o valor vai para o text
        }

        private void lblDados_Click(object sender, EventArgs e)
        {
            frmConfirmarSenha frm = new frmConfirmarSenha();
            frm.Show();
            this.Hide();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            new frmRelatorio().Show();
            this.Hide();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }

        private void txtPesquisarplaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres numero e letra
                e.Handled = true;
        }
        private void txtCódigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres somente numero
                e.Handled = true;
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int idEstacionar = Convert.ToInt32(txtCodigo.Text);

            dt = estacionarDAO.pesqCodigo(idEstacionar);

            if (dt.Rows.Count == 1)
            {
                dgvVeiculos.DataSource = estacionarDAO.pesqCodigo(idEstacionar);
                txtCodigo.Clear();
            }
            else
            {
                vagasOcupadas();
                txtCodigo.Focus();
            }

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }

        private void txtPesquisarplaca_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           
            if (txtCodigo.Text.Length != 0)
            {
                int idEstacionar = Convert.ToInt32(txtCodigo.Text);

                dt = estacionarDAO.pesqCodigo(idEstacionar);

                if (dt.Rows.Count == 1)
                {
                    lblMensagem.Text = "";
                    dgvVeiculos.DataSource = estacionarDAO.pesqCodigo(idEstacionar);
                }
                if (dt.Rows.Count < 1)
                {
                    lblMensagem.Text = "Erro ao encontrar cliente";
                    txtCodigo.Focus();
                }
            }
            else
            {
                lblMensagem.Text = "";
            }
        }

            private void txtPesquisarplaca_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string placa = txtPesquisarplaca.Text.ToUpper();//recebe os parametros

            dt = estacionarDAO.pesqPlaca(placa);//recebe o resultado

            if(txtPesquisarplaca.Text.Length == 7)
            {

                if (dt.Rows.Count >= 1)//se as linhas forem afetadas, carrega o grid
                {
                    lblMensagem.Text = "";
                    dgvVeiculos.DataSource = estacionarDAO.pesqPlaca(placa);
                }
                else//se linhas nao forem afetadas
                {
                    lblMensagem.Text = "Erro ao encontrar cliente";//mensagem de erro
                    txtPesquisarplaca.Focus();
                    vagasOcupadas();
                }
            }
            else
            {
                lblMensagem.Text = "";
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string cpf = txtCpf.Text;//passa o parametro

            dt = estacionarDAO.pesqCpf(cpf);//recebe o resultado

            if (txtCpf.Text.Length == 11)
            {

                if (dt.Rows.Count >= 1)
                {
                    lblMensagem.Text = "";
                    dgvVeiculos.DataSource = estacionarDAO.pesqCpf(cpf);//carrega o grid
                    dgvVeiculos.Refresh();
                }
                else
                {
                    lblMensagem.Text = "Erro ao encontrar cliente";//mensagem de erro
                    txtCpf.Focus();
                    vagasOcupadas();
                }
            }
            else
            {
                lblMensagem.Text = "";
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int idEstacionar = Convert.ToInt32(txtCodigo.Text);

            dt = estacionarDAO.pesqCodigo(idEstacionar);

            if (dt.Rows.Count == 1)
            {
                lblMensagem.Text = "";
                dgvVeiculos.DataSource = estacionarDAO.pesqCodigo(idEstacionar);
                txtCodigo.Clear();
            }
            else
            {
                lblMensagem.Text = "Erro ao encontrar cliente";
                vagasOcupadas();
                txtCodigo.Focus();
            }

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtPesquisarplaca.Clear();
            txtCpf.Clear();
            mskHora.Clear();
        }

        private void mskHora_TextChanged(object sender, EventArgs e)
        {
            mskHora.Focus();

            if (mskHora.Text.Length == 5)
            {
                decimal Valor;
                TimeSpan Hora = Convert.ToDateTime(mskHora.Text).TimeOfDay;//recebe o parametro
                decimal Minutos = Convert.ToDecimal(Hora.TotalMinutes.ToString());//converte para minutos

                Valor = (Minutos * 15) / 100;

                Valor = Math.Round(Valor, 2);//passa o valor e defini quantas casas decimais

                lblPreco.Text = Valor.ToString();//o valor vai para o text
            }
            else
            {
                lblPreco.Text = "";
            }
            
        }

        private void dgvEstacionamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 253)
            {
                Menu.Width = 92;
            }
            if (Menu.Width == 92)
            {
                Menu.Width = 252;
            }
        }

        private void ptbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbNormal.Visible = false;
            ptbMaximar.Visible = true;
        }

        private void ptbMaximar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbNormal.Visible = true;
            ptbMaximar.Visible = false;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbMenu_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 253)
            {
                Menu.Width = 92;
            }
            else
            {
                Menu.Width = 253;
            }
        }
    }
}
