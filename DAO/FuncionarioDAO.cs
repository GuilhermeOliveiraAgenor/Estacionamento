using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;


namespace Controller
{
    public class FuncionarioDAO
    {
        //string de conexao
        private string conectar = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

        public bool inserirFuncionario(Funcionario funcionario)
        {
            //conecta com a string de conexao
            SqlConnection conn = new SqlConnection(conectar);

            bool result = false;
            int cadastrar;

            try
            {
                conn.Open();
                SqlCommand cmdo = new SqlCommand("inserirFuncionario", conn);
                cmdo.CommandType = CommandType.StoredProcedure;//Definir como procedure e passar parametros
                cmdo.Parameters.Add("@primeiroNome", SqlDbType.VarChar, 60).Value = funcionario.primeiroNome;
                cmdo.Parameters.Add("@Sobrenome", SqlDbType.VarChar, 100).Value = funcionario.Sobrenome;
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar, 11).Value = funcionario.Cpf;
                cmdo.Parameters.Add("@Rg", SqlDbType.VarChar, 20).Value = funcionario.Rg;
                cmdo.Parameters.Add("@Profissao", SqlDbType.VarChar, 40).Value = funcionario.Profissao;
                cmdo.Parameters.Add("@Salario", SqlDbType.Decimal).Value = funcionario.Salario;

                cadastrar = cmdo.ExecuteNonQuery();
                //se linhas forem afetadas, o result retorna true
                if (cadastrar >= 1)
                {
                    result = true;
                }
                if (cadastrar < 1)//se nao, é false e retorna erro
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar. O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                //retorna mensagem de erro
            }
            finally
            {
                conn.Close();//fecha conexao
            }

            return result;
        }

        public DataTable selecionarFuncionario(string cpf)
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select *from Funcionario where Cpf = @Cpf";
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar,11).Value = cpf;//parametro

                SqlDataReader dr = cmdo.ExecuteReader();
                dt.Load(dr);//carrega dt

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();//fechar conexao
            }
            return dt;
        }

    }


}
