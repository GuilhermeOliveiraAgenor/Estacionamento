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
using Org.BouncyCastle.Crypto.Engines;

namespace Controller
{
    public class ClienteDAO
    {
        //string de conexao
        private string conectar = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

        public bool inserirCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(conectar);
            int cadastrar;
            bool result = false;

            try
            {
                conn.Open();//abri conexao
                SqlCommand cmdo = new SqlCommand("inserirCliente", conn);//defini a procedure
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@Nome", SqlDbType.VarChar, 150).Value = cliente.Nome;//parametros
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar, 11).Value = cliente.Cpf;
                cmdo.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = cliente.Email;

                cadastrar = cmdo.ExecuteNonQuery();//recebe o resultado

                if (cadastrar >= 1)//se for maior ou igual a 1, retorna true
                {
                    result = true;
                }
                if (cadastrar < 1)//se for menor que 1, retorna false
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar.O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
            }
            finally
            {
                conn.Close();//fechar conexao
            }

            return result;

        }
        public DataTable PesqClienteCpf(string cpf)
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select idCliente as Código, Nome, Cpf, Email from Cliente where Cpf = @Cpf";
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar, 11).Value = cpf;//parametro
                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();//fecha conexao
            }

            return dt;

        }

        public DataTable carregarClientes()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini o comando
                cmdo.CommandText = "select idCliente as Código, Nome, Cpf, Email from Cliente";
                SqlDataReader dr = cmdo.ExecuteReader();
                dt.Load(dr);//carrega no dt

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

        public bool editarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(conectar);
            int atualizar;
            bool result = false;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("editarCliente", conn);//defini a procedure
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@Nome", SqlDbType.VarChar, 150).Value = cliente.Nome;//passa os parametros
                cmdo.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = cliente.Email;
                cmdo.Parameters.Add("@idCliente", SqlDbType.Int).Value = cliente.idCliente;

                atualizar = cmdo.ExecuteNonQuery();//recebe o valor

                if (atualizar >= 1)//se for maior igual ou maior 1, retorna true
                {
                    result = true;
                }
                if (atualizar < 1)//se for menor que 1, retorna false
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar. O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //retorna mensagem de erro
            }
            finally
            {
                conn.Close();//fechar conexao
            }

            return result;
        }

        public DataTable PesqClienteNome(string nome)
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir comando
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini o tipo text
                cmdo.CommandText = "select idCliente as Código, Nome, Cpf, Email from Cliente where Nome like @Nome";//seleciona os nomes que começa com o que foi pesquisado
                cmdo.Parameters.Add("@Nome", SqlDbType.VarChar, 150).Value = nome + '%';//parametro
                SqlDataReader dr = cmdo.ExecuteReader();
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

    }

}



