using System; 
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using Model;

namespace Controller
{
    public class clienteVeiculoDAO
    {

        private string conectar = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        public bool InserirClienteVeiculo(Cliente cliente, clienteVeiculo cliveiculo)
        {
            //string de conexao
            SqlConnection conn = new SqlConnection(conectar);

            bool result = false;
            int cadastrar;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("InserirClienteVeiculo", conn);//defini procedure
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@Placa", SqlDbType.VarChar, 10).Value = cliveiculo.Placa;//parametros
                cmdo.Parameters.Add("@codigo_Veiculo", SqlDbType.Int).Value = cliveiculo.codigo_Veiculo;
                cmdo.Parameters.Add("@Nome", SqlDbType.VarChar, 150).Value = cliente.Nome;
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar, 11).Value = cliente.Cpf;
                cmdo.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = cliente.Email;

                cadastrar = cmdo.ExecuteNonQuery();//recebe o resultado

                if (cadastrar >= 1)
                {
                    result = true;
                }
                if (cadastrar < 1)
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
        public DataTable pesqPlaca(string placa)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Cliente.Nome, Cliente.Cpf, clienteVeiculo.Placa, Veiculo.descricaoVeiculo as Veículo from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo where clienteVeiculo.Placa = @Placa ";
                cmdo.Parameters.Add("@Placa", SqlDbType.VarChar, 10).Value = placa;//parametro

                SqlDataReader dr = cmdo.ExecuteReader();
                dt.Load(dr);//carrega o dt

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar. O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //retorna mensagem de erro
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        public List<clienteVeiculo> listVeiculosCpf(string cpf)
        {
            List<clienteVeiculo> cliVeiculo = new List<clienteVeiculo>();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select clienteVeiculo.Placa,clienteVeiculo.IdClienteVeiculo from clienteVeiculo inner join Cliente on Cliente.idCliente = clienteVeiculo.codigo_Cliente where Cliente.Cpf = @Cpf";
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar, 11).Value = cpf;//parametro
                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                while (dr.Read())//carrega as informaçoes
                {
                    cliVeiculo.Add(new clienteVeiculo()
                    {
                        IdClienteVeiculo = Convert.ToInt32(dr["IdClienteVeiculo"].ToString()),
                        Placa = dr["Placa"].ToString(),
                    });
                    ;
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
            return cliVeiculo;

        }

        public List<clienteVeiculo> listarVeiculos()
        {

            List<clienteVeiculo> cliVeiculo = new List<clienteVeiculo>();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select clienteVeiculo.Placa,clienteVeiculo.IdClienteVeiculo, Veiculo.idVeiculo from clienteVeiculo inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo";
                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                while (dr.Read())//carrega as informaçoes
                {
                    cliVeiculo.Add(new clienteVeiculo()
                    {
                        IdClienteVeiculo = Convert.ToInt32(dr["IdClienteVeiculo"].ToString()),
                        Placa = dr["Placa"].ToString(),
                        codigo_Veiculo = Convert.ToInt32(dr["idVeiculo"].ToString()),

                    });
                    ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar. O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //retorna mensagem de erro   
            }

            finally
            {
                conn.Close();
            }
            return cliVeiculo;

        }

        public DataTable CarregarClienteVeiculo()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini comando tipo text
                cmdo.CommandText = "select Cliente.Nome, Cliente.Cpf, Cliente.Email, clienteVeiculo.Placa,Veiculo.descricaoVeiculo as Veículo from clienteVeiculo inner join Cliente on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo";
                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado

                dt.Load(dr);//carrega as informações
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
            return dt;

        }

        public DataTable pesqCpf(string cpf)
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abri conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//definir comando text
                cmdo.CommandText = "select Cliente.Nome,Cliente.Cpf,clienteVeiculo.Placa, Veiculo.descricaoVeiculo as Veículo,Veiculo.Marca from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo  where Cliente.Cpf = @Cpf";
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar, 11).Value = cpf;//parametro

                SqlDataReader dr = cmdo.ExecuteReader();
                dt.Load(dr);//carrega a informação

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

            return dt;

        }

        public bool inserirVeiculocv(clienteVeiculo cliveiculo, Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(conectar);
            bool result = false;
            int cadastrar;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("InserirVeiculoCv", conn);//definir procedure
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@codigo_Veiculo", SqlDbType.Int).Value = cliveiculo.codigo_Veiculo;
                cmdo.Parameters.Add("@Placa", SqlDbType.VarChar, 10).Value = cliveiculo.Placa;
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar, 11).Value = cliente.Cpf;

                cadastrar = cmdo.ExecuteNonQuery();//recebe o resultado

                if (cadastrar >= 1)
                {
                    result = true;
                }
                if (cadastrar < 1)
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

    }
}