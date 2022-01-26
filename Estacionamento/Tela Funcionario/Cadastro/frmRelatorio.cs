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

            string mes = cmbMes.Text;
            string ano = txtAno.Text;

            dt = estacionarDAO.valorMes(mes, ano);

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblValor.Text = row["Valor"].ToString();
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
            //TODO: Arrumar pesquisa de hora 
            dgvRelatorio.DataSource = estacionarDAO.veiculosHoje();
            dgvRelatorio.Refresh();
        }

        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            

            if (cmbPesquisa.Text == "7 dias")
            {
                dgvRelatorio.DataSource = estacionarDAO.veiculos7dias();
                dgvRelatorio.Refresh();

                dt = estacionarDAO.valor7dias();

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

            string ano = txtAno.Text;

            dt = estacionarDAO.valorAno(ano);

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblValor.Text = row["Valor"].ToString();
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

            string mes = cmbPesqMes.Text;
            string ano = txtPesqAno.Text;

            dt = estacionarDAO.horasMes(mes,ano);

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblHora.Text = row["Horas"].ToString();
                    lblCarros.Text = row["Carros"].ToString();
                    if (lblHora.Text == "" || lblCarros.Text == "")
                    {
                        MessageBox.Show("Nenhum hora encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //mensagem de erro
                    }

                }
            }
            
        }
        private void lblPeriodo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = estacionarDAO.horas7dias();

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblHora.Text = row["Horas"].ToString();
                    lblCarros.Text = row["Carros"].ToString();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblHoras_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            dt = estacionarDAO.horas7dias();

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblHora.Text = row["Horas"].ToString();
                }
            }
           
        }

    }
}
