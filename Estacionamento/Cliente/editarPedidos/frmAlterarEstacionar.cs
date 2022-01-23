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
    public partial class frmAlterarEstacionar : Form
    {
        Estacionar estacionar = new Estacionar();
        EstacionarDAO estacionarDAO = new EstacionarDAO();
        clienteVeiculoDAO cliVeiculoDAO = new clienteVeiculoDAO();
        List<clienteVeiculo> cliVeiculo = new List<clienteVeiculo>();
        DataTable dt = new DataTable();
        int idEstacionar;
        string modo;
        public frmAlterarEstacionar()
        {
            InitializeComponent();
        }
        public void vagasOcupadas()
        {
            dgvEstacionar.DataSource = estacionarDAO.carregarVeiculo();
            dgvEstacionar.Refresh();
        }
        public void irMenu()
        {
            frmMenuu frm = new frmMenuu();
            frm.Show();
            this.Hide();
        }

        private void frmAlterarEstacionar_Load(object sender, EventArgs e)
        {
            vagasOcupadas();

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

        private void btnPesquisarcodigo_Click(object sender, EventArgs e)
        {
            string cpf = txtPesquisar.Text;//parametro

            dt = estacionarDAO.PesqCpfOcupados(cpf);//recebe o resultado

            cliVeiculo = cliVeiculoDAO.listVeiculosCpf(cpf);

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblHora.Text = row["horarioEntrada"].ToString();//passa as informaçoes
                    lblData.Text = row["dataEntrada"].ToString();
                    cmbPatio.Text = row["Patio"].ToString();
                    cmbcodigoVeiculo.Text = row["Placa"].ToString();
                    idEstacionar = Convert.ToInt32(row["idEstacionar"].GetHashCode());
                }
                foreach (var item in cliVeiculo)
                {
                    cmbcodigoVeiculo.Items.Add(item.Placa);//adiciona na combobox
                    cmbcodigoVeiculo.ValueMember = item.IdClienteVeiculo.ToString();//recebe o id da combobox
                }

            }


            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Erro ao encontrar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            modo = "alterar";//coloca a variavel em alterar
            MessageBox.Show("Clique em gravar para continuar", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbcodigoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliVeiculo = cliVeiculoDAO.listarVeiculos();//recebe o resultado

            foreach (var item in cliVeiculo)
            {
                if (cmbcodigoVeiculo.Text == item.Placa)//se o text for igual ao item selecionado, retorna id
                {
                    cmbcodigoVeiculo.ValueMember = item.IdClienteVeiculo.ToString();//recebe o id da combobox
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            irMenu();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            irMenu();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            modo = "excluir";//coloca modo excluir
            MessageBox.Show("Clique em gravar para continuar","Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {

            bool result = false;

            if (modo == "alterar")
            {
                estacionar.idEstacionar = idEstacionar;
                estacionar.Patio = Convert.ToInt32(cmbPatio.Text);//parametro
                estacionar.CodigoClienteVeiculo = Convert.ToInt32(cmbcodigoVeiculo.ValueMember);

                result = estacionarDAO.alterarEstacionar(estacionar);//recebe o resultado

                if (result == true)
                {
                    MessageBox.Show("Alteração concluída", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (modo == "excluir")
            {
                int codigo = idEstacionar;

                result = estacionarDAO.excluirEstacionar(idEstacionar);

                if (result == true)
                {
                    MessageBox.Show("Exclusão concluída", "Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (result == false)
                {
                    MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
