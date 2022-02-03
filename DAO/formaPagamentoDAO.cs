using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class formaPagamentoDAO
    {
        private string conectar = System.Configuration.ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

        formaPagamento forma = new formaPagamento();

        public List<formaPagamento> carregarDescricao()
        {
            List<formaPagamento> forma = new List<formaPagamento>();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select *from formaPagamento";

                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado

                while (dr.Read())//carrega o dr
                {
                    forma.Add(new formaPagamento()
                    {
                        idFormaPagamento = dr["idFormaPagamento"].GetHashCode(),//adiciona as informações
                        descricao = dr["descricao"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar. O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //retorna mensagem de erro
            }
            finally
            {
                conn.Close();//fechar conexao
            }

            return forma;

        }

    }
}