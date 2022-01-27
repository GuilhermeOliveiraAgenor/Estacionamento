using Controller;
using Estacionamento.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.Funcionario.Relatorio
{
    public partial class frmRelatorio : Form
    {
        EstacionarDAO estacionarDAO = new EstacionarDAO();
        public frmRelatorio()
        {
            InitializeComponent();
        }
        public void pesqMes()
        {
            DataTable dt = new DataTable();

            string mes = cmbMes.Text;//parametros
            string ano = txtAno.Text;

            dt = estacionarDAO.valorMes(mes, ano);//recebe o resultado

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblValor.Text = row["Valor"].ToString();//carrega a informaçao
                }
            }
            if(lblValor.Text == "")
            {
                MessageBox.Show("Nenhum valor encontrado. R$ 0,00", "Valor = 0.00", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
                
            }

        }
        private void btnSairmenu_Click(object sender, EventArgs e)
        {
            frmMenuu frm = new frmMenuu();
            frm.Show();
            this.Hide();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            //TODO: tela
            dgvRelatorio.DataSource = estacionarDAO.veiculosHoje();//carrega o grid
            dgvRelatorio.Refresh();
        }

        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            

            if (cmbPesquisa.Text == "7 dias")//se o text for igual a 7 dias, carrega o grid
            {
                dgvRelatorio.DataSource = estacionarDAO.veiculos7dias();//adiciona informação no grid
                dgvRelatorio.Refresh();

                dt = estacionarDAO.valor7dias();//recebe o resultado

                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        lblValor.Text = row["Valor"].ToString();
                    }
                }
                
            }
            if (cmbPesquisa.Text == "30 dias")
            {
                dgvRelatorio.DataSource = estacionarDAO.veiculos30dias();
                dgvRelatorio.Refresh();

                dt = estacionarDAO.valor30dias();

                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        lblValor.Text = row["Valor"].ToString();
                    }
                }
               
            }
            if (cmbPesquisa.Text == "Total")
            {

                dt = estacionarDAO.valorTotal();

                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        lblValor.Text = row["Valor"].ToString();
                    }
                }
               
            }
            if(lblValor.Text == "")
            {
                MessageBox.Show("Nenhum valor encontrado. R$ 0,00", "Valor = 0.00", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
            }




        }
        private void btnAno_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string ano = txtAno.Text;//parametro

            dt = estacionarDAO.valorAno(ano);//recebe o resultado

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblValor.Text = row["Valor"].ToString();//carrega a informaçao
                }
                
            }
            if (lblValor.Text == "")
            {
                MessageBox.Show("Nenhum valor encontrado. R$ 0,00", "Valor = 0.00", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesqMes();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string mes = cmbPesqMes.Text;//parametro
            string ano = txtPesqAno.Text;

            dt = estacionarDAO.horasMes(mes,ano);//recebe o resultado

            if (dt.Rows.Count >= 1)
            {
                dgvRelatorio.DataSource = estacionarDAO.horasMes(mes,ano);//carrega o grid
                dgvRelatorio.Refresh();
            }
            if(dt.Rows.Count < 1)
            {
                MessageBox.Show("Nenhum hora encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
            }

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblHoras_Click(object sender, EventArgs e)
        {
                      
        }

        private void lblHoras_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl7dias_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = estacionarDAO.horas7dias();//recebe o resultado

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvRelatorio.DataSource = estacionarDAO.horas7dias();//carrega o grid
                    dgvRelatorio.Refresh();
                }
            }
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Nenhum valor encontrado. R$ 0,00", "Valor = 0.00", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
            }
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPesqMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
