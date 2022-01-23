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

namespace Estacionamento.Entrada
{
    public partial class frmVerificar : Form
    {

        Cliente cliente = new Cliente();
        ClienteDAO clienteDAO = new ClienteDAO();
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
        
        private void btnCodigo_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();

            //passar parametros
            string cpf = txtCpf.Text;

            dt = clienteDAO.PesqClienteCpf(cpf);//recebe o resultado do datatable

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Cliente encontrado", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            frmMenuu frm = new frmMenuu();
            frm.Show();
            this.Hide();
        }
    }
}
