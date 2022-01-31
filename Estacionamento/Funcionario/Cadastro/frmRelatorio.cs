using Controller;
using Estacionamento.Menu;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private void lblPdf_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            dt = funcionarioDAO.carregarFuncionario();

            var nomeArquivo = @"C:\Funcionarios.pdf"; //caminho do arquivi
            string dados = "";
            string texto1 = "Relatório sobre o quadro de funcionários atual de funcionários no estacionamento. Nós fizemos uma busca e encontramos esse resultado.";
            string texto2 = "Confira a tabela a seguir:";

            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);//caminho do arquivo, comando pra criar
            Document documento = new Document(PageSize.A4);//defini o documento A4
            PdfWriter escritor = PdfWriter.GetInstance(documento, arquivoPDF);// documento e caminho do documento

            Paragraph pr1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, (int)System.Drawing.FontStyle.Italic));//defini tamanho e tipo da fonte
            pr1.Alignment = Element.ALIGN_CENTER;//coloca o texto centralizado
            pr1.Add("ESTACIONAMENTO ALFA PARK\n\n");
           

            Paragraph pr2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, (int)System.Drawing.FontStyle.Regular)); ;//defini tamanho e tipo da fonte

            pr2.Alignment = Element.ALIGN_LEFT;
            pr2.Add(texto1 + "\n\n" + texto2 + "\n\n\n");

            Paragraph pr3 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, (int)System.Drawing.FontStyle.Regular)); ;//defini tamanho e tipo da fonte
            pr3.Alignment = Element.ALIGN_LEFT;
            pr3.Add("\nRelatório gerado às " + DateTime.Now.ToLongTimeString() + "\n"+ "Dia: " + DateTime.Now.ToShortDateString());


            PdfPTable tabela = new PdfPTable(4);//número de colunas da tabela
            tabela.DefaultCell.FixedHeight = 20;//tamanho do campo

            PdfPCell celula1 = new PdfPCell(new Phrase("Tabela de Funcionários"));//título da tabela
            celula1.Colspan = 4;//4 linhas, 4 colunas
            celula1.Rotation = 0;
            celula1.HorizontalAlignment = Element.ALIGN_CENTER;//alinha o título
            tabela.AddCell(celula1);//adiciona título na tabela

            tabela.AddCell("Nome");//colunas
            tabela.AddCell("Cpf");
            tabela.AddCell("Profissão");
            tabela.AddCell("Salário");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tabela.AddCell(dt.Rows[i].Field<string>("primeiroNome").ToString());//adiciona as informaçoes carregadas
                tabela.AddCell(dt.Rows[i].Field<string>("Cpf").ToString());
                tabela.AddCell(dt.Rows[i].Field<string>("Profissao").ToString());
                tabela.AddCell(dt.Rows[i].Field<decimal>("Salario").ToString());
            }

            documento.Open();//abre o documento
            documento.Add(pr1);//adiciona os paragrafos
            documento.Add(pr2);
            documento.Add(tabela);//adicionar tabela
            documento.Add(pr3);
            documento.Close();//fecha o documento

            System.Diagnostics.Process.Start(@"C:\Funcionarios.pdf");

        }
    }
}
