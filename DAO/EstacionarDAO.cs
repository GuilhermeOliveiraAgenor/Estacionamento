using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Model;

namespace Controller
{
    public class EstacionarDAO
    {

        private string conectar = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

        public bool Entrada(Estacionar estacionar)
        {
            SqlConnection conn = new SqlConnection(conectar);
            bool result = false;
            int cadastrar;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("Entrada", conn);//defini a procedure
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@dataEntrada", SqlDbType.DateTime).Value = estacionar.dataEntrada;
                cmdo.Parameters.Add("@Patio", SqlDbType.Int).Value = estacionar.Patio;
                cmdo.Parameters.Add("@CodigoClienteVeiculo", SqlDbType.Int).Value = estacionar.CodigoClienteVeiculo;

                cadastrar = cmdo.ExecuteNonQuery();//recebe o resultado

                if (cadastrar >= 1)//se linhas forem afetadas, retorna true
                {
                    result = true;
                }
                if (cadastrar < 1)//se linhas não forem afetadas, retornar false
                {
                    result = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao concluir entrada - O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();//retorna a conexao
            }

            return result;
        }

        public bool Saida(Estacionar estacionar, Pagamento pagamento)
        {
            SqlConnection conn = new SqlConnection(conectar);//conexao
            int cadastrar;
            bool result = false;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("Saida", conn);//definir procedure
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@dataSaida", SqlDbType.DateTime).Value = estacionar.dataSaida;
                cmdo.Parameters.Add("@Preco", SqlDbType.Decimal).Value = estacionar.Preco;
                cmdo.Parameters.Add("@idEstacionar", SqlDbType.Int).Value = estacionar.idEstacionar;
                cmdo.Parameters.Add("@CodigoFormaPagamento", SqlDbType.Int).Value = pagamento.CodigoFormaPagamento;

                cadastrar = cmdo.ExecuteNonQuery();//recebe o valor

                if (cadastrar >= 1)//se for 1, retorna true
                {
                    result = true;
                }
                if (cadastrar < 1)//se não for maior que 1, é false
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer a saída - O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
            }

            finally
            {
                conn.Close();//fechar conexao
            }

            return result;
        }

        public DataTable pesqVeiculo(string Placa)
        {
            SqlConnection conn = new SqlConnection(conectar);//conexao
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abre conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini tipo text
                cmdo.CommandText = "select Estacionar.idEstacionar as Código, Estacionar.dataEntrada as Entrada, clienteVeiculo.Placa from Estacionar inner join clienteVeiculo on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo where Placa = @Placa and Status = 'Ocupado'";
                cmdo.Parameters.Add("@Placa", SqlDbType.VarChar,10).Value = Placa;//passa parametro

                SqlDataReader dr = cmdo.ExecuteReader();//recebe o valor
                dt.Load(dr);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar. O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //retorna mensagem de erro
            }
            finally
            {
                conn.Close();//fecha conexao
            }

            return dt;


        }

        public DataTable carregarVeiculo()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//definir como text
                cmdo.CommandText = "select Estacionar.idEstacionar as Código, Cliente.Nome, Cliente.Cpf, Veiculo.descricaoVeiculo as Veículo,clienteVeiculo.Placa,Estacionar.dataEntrada as Entrada, Estacionar.Preco as Preço, Estacionar.Patio as Pátio, Estacionar.Status from Estacionar inner join clienteVeiculo on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo inner join Cliente on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo where Estacionar.Status = 'Ocupado'";
                SqlDataReader dr = cmdo.ExecuteReader();
                dt.Load(dr);//carrega o datatable

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

        public DataTable veiculosHoje()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini tipo
                cmdo.CommandText = "select Cliente.Nome, Cliente.Cpf, Cliente.Email, Veiculo.descricaoVeiculo as Veículo, clienteVeiculo.Placa, Estacionar.dataEntrada as Entrada, Estacionar.dataSaida as Saída, Estacionar.Preco, Estacionar.Patio as Pátio from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Estacionar on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo where dataEntrada between CONVERT(date,GETDATE()) and dataEntrada";
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
                conn.Close();//fechar conexao
            }

            return dt;

        }

        public DataTable vagasPatio1()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Patio.Vagas - (select COUNT(idEstacionar) from Estacionar where Patio = '1' and Estacionar.Status = 'Ocupado') as Patio1 from Patio where Patio.Patio = '1'";

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
                conn.Close();//fechar conexao
            }

            return dt;

        }

        public DataTable vagasPatio2()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Patio.Vagas - (select COUNT(idEstacionar) from Estacionar where Patio = '2' and Estacionar.Status = 'Ocupado') as Patio2 from Patio where Patio.Patio = '2'";
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
                conn.Close();//fechar conexao
            }

            return dt;

        }

        public DataTable pesqPlaca(string placa)
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Cliente.Nome, Cliente.Cpf, Veiculo.descricaoVeiculo as Veículo,clienteVeiculo.Placa,Estacionar.Patio as Pátio, Estacionar.Preco as Preço, Estacionar.dataEntrada as Entrada, Estacionar.dataSaida as Saída from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Estacionar on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo where clienteVeiculo.Placa = @Placa";
                cmdo.Parameters.Add("@Placa", SqlDbType.VarChar,10).Value = placa;//parametro

                SqlDataReader dr = cmdo.ExecuteReader();
                dt.Load(dr);//carrega dt
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
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Cliente.Nome, Cliente.Cpf, Veiculo.descricaoVeiculo as Veículo, clienteVeiculo.Placa, Estacionar.dataEntrada as Entrada, Estacionar.dataSaida as Saída, Estacionar.Preco as Preço, Estacionar.Patio as Pátio from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Estacionar on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo where Cliente.Cpf = @Cpf";
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar,11).Value = cpf;//parametro

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
                conn.Close();//fechar conexao
            }

            return dt;
        }

        public DataTable pesqCodigo(int idEstacionar)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Cliente.Nome, Cliente.Cpf, Veiculo.descricaoVeiculo as Veículo, clienteVeiculo.Placa, Estacionar.dataEntrada as Entrada, Estacionar.dataSaida as Saída, Estacionar.Preco as Preço, Estacionar.Patio as Pátio from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Estacionar on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo where Estacionar.idEstacionar  = @idEstacionar";
                cmdo.Parameters.Add("@idEstacionar", SqlDbType.Int).Value = idEstacionar;//parametro
                
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
                conn.Close();//fechar conexao
            }

            return dt;

        }
        public bool alterarEstacionar(Estacionar estacionar)
        {
            SqlConnection conn = new SqlConnection(conectar);
            int alterar;
            bool result = false;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("alterarEstacionar", conn);//defini procedure
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@CodigoClienteVeiculo", SqlDbType.Int).Value = estacionar.CodigoClienteVeiculo;
                cmdo.Parameters.Add("@Patio", SqlDbType.Int).Value = estacionar.Patio;
                cmdo.Parameters.Add("@idEstacionar", SqlDbType.Int).Value = estacionar.idEstacionar;

                alterar = cmdo.ExecuteNonQuery();//recebe o resultado

                if (alterar >= 1)//se linha forem afetadas, retorna true
                {
                    result = true;
                }
                if (alterar < 1)//se linhas nao forem afetadas, retorna false
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar - O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
            }
            finally
            {
                conn.Close();//fechar conexao
            }

            return result;
        }
        public DataTable PesqCpfOcupados(string cpf)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Estacionar.idEstacionar as Código, Cliente.Nome, Cliente.Cpf, Veiculo.descricaoVeiculo as Veículo, clienteVeiculo.Placa, Estacionar.dataEntrada as Entrada, Estacionar.Preco as Preço, Estacionar.Patio as Pátio from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Estacionar on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo where Cliente.Cpf = @Cpf and Estacionar.Status = 'Ocupado'";
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar,11).Value = cpf;//parametro

                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt

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
        public bool excluirEstacionar(int idEstacionar)
        {
            SqlConnection conn = new SqlConnection(conectar);
            int excluir;
            bool result = false;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("excluirEstacionar", conn);//defini text
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@idEstacionar", SqlDbType.Int).Value = idEstacionar;//parametro

                excluir = cmdo.ExecuteNonQuery();//recebe o resultado

                if (excluir >= 1)//se 1 ou mais linhas forem afetadas, retorna true
                {
                    result = true;
                }
                if (excluir < 1)//se linhas não forem afetadas, retorna false
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir. O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //retorna mensagem de erro
            }
            finally
            {
                conn.Close();//fecha conexao
            }

            return result;
        }
        public DataTable valor7dias()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select sum(Preco) as Valor from Estacionar where dataSaida >= DATEADD(day, -7, GETDATE())";
                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt

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
        public DataTable valor30dias()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select sum(Preco) as Valor from Estacionar where dataSaida >= DATEADD(day, -30, GETDATE())";
                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt

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
        public DataTable veiculos7dias()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Cliente.Nome, Cliente.Cpf, Cliente.Email, Veiculo.descricaoVeiculo as Veículo, clienteVeiculo.Placa, Estacionar.dataEntrada as Entrada, Estacionar.dataSaida as Saída, Estacionar.Preco as Preço, Estacionar.Patio as Pátio from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Estacionar on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo where dataSaida >= DATEADD(day, -7, GETDATE())";
                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt

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
        public DataTable veiculos30dias()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Cliente.Nome, Cliente.Cpf, Cliente.Email, Veiculo.descricaoVeiculo as Veículo, clienteVeiculo.Placa, Estacionar.dataEntrada as Entrada, Estacionar.dataSaida as Saída, Estacionar.Preco as Preço, Estacionar.Patio as Pátio from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Estacionar on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo inner join Veiculo on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo where dataSaida >= DATEADD(day, -30, GETDATE())";
                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt

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
        public DataTable valorMes(string mes, string ano)
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select sum(Preco) as Valor from Estacionar where MONTH(dataSaida) = @Mes and YEAR(dataSaida) = @Ano";
                cmdo.Parameters.Add("@Mes", SqlDbType.VarChar).Value = mes;
                cmdo.Parameters.Add("@Ano", SqlDbType.VarChar).Value = ano;

                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt

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
        public DataTable valorAno(string ano)
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select sum(Preco) as Valor from Estacionar where YEAR(dataSaida) = @Ano";
                cmdo.Parameters.Add("@Ano", SqlDbType.VarChar).Value = ano;

                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt

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
        public DataTable valorTotal()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select sum(Preco) as Valor from Estacionar";

                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt

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
        public DataTable horasMes(string mes, string ano)
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select DATEPART(HOUR,dataEntrada) as Hora, COUNT(*) as Carros from Estacionar where MONTH(dataSaida) = @Mes and YEAR(dataSaida) = @Ano group by DATEPART(HOUR,dataEntrada) having COUNT(*) > 1 order by Carros desc";
                cmdo.Parameters.Add("@Mes", SqlDbType.VarChar).Value = mes;//parametro
                cmdo.Parameters.Add("@Ano", SqlDbType.VarChar).Value = ano;

                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt

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
        public DataTable horas7dias()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select DATEPART(HOUR,dataEntrada) as Hora, COUNT(*) as Carros from Estacionar where dataSaida >= DATEADD(day, -7, GETDATE()) group by DATEPART(HOUR,dataEntrada) having COUNT(*) > 1 order by Carros desc";

                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt

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


    }
}