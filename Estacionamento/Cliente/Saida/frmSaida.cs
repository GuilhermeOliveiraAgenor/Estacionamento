using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Estacionamento.editarPedidos;
using Estacionamento.Entrada;
using Estacionamento.Login;
using Estacionamento.Menu;
using Model;

namespace Estacionamento.Saida
{
    public partial class frmSaida : Form
    {

        EstacionarDAO estacionarDAO = new EstacionarDAO();
        Estacionar estacionar = new Estacionar();
        formaPagamentoDAO formaDAO = new formaPagamentoDAO();
        Pagamento pagamento = new Pagamento();
        DateTime horaEntrada = new DateTime();
        DateTime horaSaida = new DateTime();
        DateTime data = new DateTime();

        int codigoEstacionar;
        decimal Valor;
        decimal Min;
       

        public frmSaida()
        {
            InitializeComponent();
        }
        public void carregarGrid()
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            dt = estacionarDAO.vagasPatio1();//recebe o resultado

            dt1 = estacionarDAO.vagasPatio2();

            if (dt.Rows.Count <= 1 && dt1.Rows.Count <= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblPatio1.Text = row["Patio1"].ToString();
                }
                foreach (DataRow row1 in dt1.Rows)
                {
                    lblPatio2.Text = row1["Patio2"].ToString();
                }
            }
            dgvEstacionamento.DataSource = estacionarDAO.carregarVeiculo();
        }

        public void limparCampos()
        {
            lblPlaca.Text = "";
            lblHoraEntrada.Text = "";
            lblCalcular.Text = "";
            lblPrecohora.Text = "";
            cmbFormadepagamento.Text = "";
            txtPesquisar.Clear();
            dgvEstacionamento.Enabled = true;
            btnSaida.Enabled = false;
            codigoEstacionar = 0;
            horaEntrada = Convert.ToDateTime("00:00");
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            string placa = txtPesquisar.Text;
            DataTable dt = new DataTable();

            horaSaida = Convert.ToDateTime(DateTime.Now.ToString("T", System.Globalization.DateTimeFormatInfo.InvariantInfo));
            data = Convert.ToDateTime(DateTime.Now.ToString("D", System.Globalization.DateTimeFormatInfo.InvariantInfo));

            dt = estacionarDAO.pesqVeiculo(placa);//recebe o resultado

             if (dt.Rows.Count == 1)//se linhas forem afetadas, as informações vao ser carregadas
             {

                dgvEstacionamento.Enabled = false;
                btnSaida.Enabled = false;

                 foreach (DataRow row in dt.Rows)
                 {
                    lblPlaca.Text = row["Placa"].ToString();
                    lblHoraEntrada.Text = row["horarioEntrada"].ToString();
                    horaEntrada = Convert.ToDateTime(lblHoraEntrada.Text);
                    codigoEstacionar = row["idEstacionar"].GetHashCode();

                 }

                //calculo das horas
                TimeSpan horas = horaSaida - horaEntrada;

                lblCalcular.Text = horas.ToString();
               
                 Min = Convert.ToDecimal(horas.TotalMinutes.ToString());
                Valor = (Min * 15) / 100;
               
                Valor = Math.Round(Valor, 2);//passa o valor e defini quantas casas decimais

                lblPrecohora.Text = Valor.ToString();//o valor vai para o text

                txtPesquisar.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao encontrar cliente.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//mensagem de erro
                txtPesquisar.Focus();
                cmbFormadepagamento.Text = "";
                btnSaida.Enabled = false;
                carregarGrid();
                limparCampos();
            }
            
}
        

        private void btnSaida_Click(object sender, EventArgs e)
        {
            bool result = false;

            if (codigoEstacionar == 0 || String.IsNullOrEmpty(lblPrecohora.Text) || String.IsNullOrEmpty(cmbFormadepagamento.ValueMember))//verificar campos vazios
            {
                MessageBox.Show("Preencha os campos ou selecione a veiculo novamente", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   

            else
            {

                estacionar.horarioSaida = horaSaida;//parametros
                estacionar.dataSaida = data;
                estacionar.Preco = Convert.ToDecimal(lblPrecohora.Text);
                estacionar.idEstacionar = codigoEstacionar;
                pagamento.CodigoFormaPagamento = Convert.ToInt32(cmbFormadepagamento.ValueMember);


                result = estacionarDAO.Saida(estacionar, pagamento);//recebe o resultado

                if (result == true)
                {
                    MessageBox.Show("Saida concluída com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregarGrid();
                    limparCampos();
                }
            }

        }
        private void frmSaida_Load(object sender, EventArgs e)
        {
            List<formaPagamento> forma = new List<formaPagamento>();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            carregarGrid(); 

            forma = formaDAO.carregarDescricao();

            foreach (var item in forma)
            {
                cmbFormadepagamento.Items.Add(item.descricao);//adiciona a informação na combobox
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();

        }

        private void dgvEstacionamento_SelectionChanged(object sender, EventArgs e)
        {
            int linha = 0;

            btnSaida.Enabled = false;
            cmbFormadepagamento.Text = "";
            horaSaida = Convert.ToDateTime(DateTime.Now.ToString("T", System.Globalization.DateTimeFormatInfo.InvariantInfo));
            data = Convert.ToDateTime(DateTime.Now.ToString("D", System.Globalization.DateTimeFormatInfo.InvariantInfo));


            linha = dgvEstacionamento.CurrentRow.Index;
            codigoEstacionar = Convert.ToInt32(dgvEstacionamento[0, linha].Value.ToString());
            lblPlaca.Text = dgvEstacionamento[4, linha].Value.ToString();
            lblHoraEntrada.Text = dgvEstacionamento[5, linha].Value.ToString();
           
            horaEntrada = Convert.ToDateTime(lblHoraEntrada.Text);
            //calculo das horas
            TimeSpan horas = horaSaida - horaEntrada;

            lblCalcular.Text = horas.ToString();

            Min = Convert.ToDecimal(horas.TotalMinutes.ToString());
            Valor = (Min * 15) / 100;

            Valor = Math.Round(Valor, 2);//passa o valor e defini quantas casas decimais

            lblPrecohora.Text = Valor.ToString();//o valor vai para o text
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new frmMenuu().Show();
            this.Hide();
        }

        private void cmbFormadepagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<formaPagamento> forma = formaDAO.carregarDescricao();//recebe o resultado

            foreach (var item in forma)
            {
                if (cmbFormadepagamento.Text == item.descricao)//se o item selecionado for igual, retorna id
                {
                    cmbFormadepagamento.ValueMember = item.idFormaPagamento.ToString();//recebe o id da combobox
                }
            }
            btnSaida.Enabled = true;
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
        private void frmSaida_DoubleClick(object sender, EventArgs e)
        {
            carregarGrid();
            limparCampos();
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))//defini os caracteres numero e letra
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void cmbFormadepagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
