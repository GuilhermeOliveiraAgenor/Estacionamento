using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;


namespace Controller
{
    public class VeiculoDAO
    {
        private string conectar = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

        public bool inserirVeiculo(Veiculo veiculo)
        {
            SqlConnection conn = new SqlConnection();
            bool result = false;
            int cadastrar;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("inserirVeiculo", conn);//defini a procedure e passa parametros
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@Categoria", SqlDbType.VarChar, 20).Value = veiculo.Categoria;
                cmdo.Parameters.Add("@Marca", SqlDbType.VarChar, 20).Value = veiculo.Marca;
                cmdo.Parameters.Add("@descricaoVeiculo", SqlDbType.VarChar, 40).Value = veiculo.descricaoVeiculo;

                cadastrar = cmdo.ExecuteNonQuery();//recebe o resultado

                if (cadastrar >= 1)//se afetar linhas, retorna true
                {
                    result = true;
                }
                if (cadastrar < 1)//se afetar linhas, retorna true
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar. O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //retorna erro
            }
            finally
            {
                conn.Close();//fechar conexao
            }

            return result;

        }

        public List<Veiculo> carregarVeiculo()
        {

            List<Veiculo> veiculos = new List<Veiculo>();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select *from Veiculo order by descricaoVeiculo";
                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado

                while (dr.Read())//recebe as informaçoes
                {
                    veiculos.Add(new Veiculo()
                    {
                        idVeiculo = Convert.ToInt32(dr["idVeiculo"].ToString()),//adiciona as informaçoes
                        Categoria = dr["Categoria"].ToString(),
                        Marca = dr["Marca"].ToString(),
                        descricaoVeiculo = dr["descricaoVeiculo"].ToString(),
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
                conn.Close();//fecha a conexao
            }
            return veiculos;
        }


    }
}