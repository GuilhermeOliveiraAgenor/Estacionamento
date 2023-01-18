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
        public bool inserirFuncionario(Funcionarios funcionario, Usuario usuario)
        {
            //conecta com a string de conexao
           SqlConnection conn = new SqlConnection(conectar);
           byte[] foto = funcionario.GetFoto(funcionario.caminhoFoto);//recebe o resultado

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
                cmdo.Parameters.Add("@Foto", SqlDbType.Image, foto.Length).Value = foto;
                cmdo.Parameters.Add("@Acesso", SqlDbType.Int).Value = usuario.Acesso;
         
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
                MessageBox.Show("Erro ao cadastrar. O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmdo.CommandText = "select Funcionarios.idFuncionario as Código,Funcionarios.primeiroNome as Nome,Funcionarios.Sobrenome,Funcionarios.Cpf,Funcionarios.Rg, Funcionarios.Profissao as Profissão, Funcionarios.Salario as Salário, Funcionarios.Foto, nivelAcesso.idNivelAcesso,nivelAcesso.Nivel as Nível from Funcionarios inner join Usuario on Funcionarios.idFuncionario = Usuario.codigoFuncionario inner join nivelAcesso on nivelAcesso.idNivelAcesso = Usuario.Acesso where Funcionarios.Cpf = @Cpf";
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar,11).Value = cpf;//parametro

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

        public bool alterarFuncionario(Funcionarios funcionario, Usuario usuario)
        {
            SqlConnection conn = new SqlConnection(conectar);

            bool result = false;
            int alterar;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("alterarFuncionario", conn);//defini procedure
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@idFuncionario", SqlDbType.Int).Value = funcionario.idFuncionario;//parametros
                cmdo.Parameters.Add("@primeiroNome", SqlDbType.VarChar, 60).Value = funcionario.primeiroNome;
                cmdo.Parameters.Add("@Sobrenome", SqlDbType.VarChar, 100).Value = funcionario.Sobrenome;
                cmdo.Parameters.Add("@Rg", SqlDbType.VarChar, 20).Value = funcionario.Rg;
                cmdo.Parameters.Add("@Profissao", SqlDbType.VarChar, 40).Value = funcionario.Profissao;
                cmdo.Parameters.Add("@Salario", SqlDbType.Decimal).Value = funcionario.Salario;
                cmdo.Parameters.Add("@Acesso", SqlDbType.Int).Value = usuario.Acesso;

                alterar = cmdo.ExecuteNonQuery();//recebe o resultado

                if (alterar >= 1)//se linhas forem afetadas, retorna true
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
                MessageBox.Show("Erro ao alterar. O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //retorna mensagem de erro
            }
            finally
            {
                conn.Close();//fechar conexao
            }

            return result;

        }

        public bool excluirFuncionario(int idFuncionario)
        {
            SqlConnection conn = new SqlConnection(conectar);
            int excluir;
            bool result = false;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("excluirFuncionario", conn);//defini text
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@idFuncionario", SqlDbType.Int).Value = idFuncionario;//parametro

                excluir = cmdo.ExecuteNonQuery();//recebe o resultado

                if (excluir >= 1)//se linhas forem afetadas, retorna true
                {
                    result = true;
                }
                if (excluir < 1)//se linhas nao forem afetadas, retorna false
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
                conn.Close();//fechar conexao
            }

            return result; 

        }
        
        public DataTable carregarFuncionario()
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Funcionarios.idFuncionario as Código, Funcionarios.primeiroNome as Nome, Funcionarios.Sobrenome, Funcionarios.Cpf, Funcionarios.Rg, Funcionarios.Profissao as Profissão, Funcionarios.Salario as Salário, nivelAcesso.Nivel as Nível from Funcionarios inner join Usuario on Funcionarios.idFuncionario = Usuario.codigoFuncionario inner join nivelAcesso on nivelAcesso.idNivelAcesso = Usuario.Acesso";

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

        public bool alterarFoto(Funcionarios funcionario)
        {
            SqlConnection conn = new SqlConnection(conectar);
            byte[] foto = funcionario.GetFoto(funcionario.caminhoFoto);//recebe o resultado
            bool result = false;
            int alterar;

            try
            {
                conn.Open();//abrir conexao
                SqlCommand cmdo = new SqlCommand("alterarFoto", conn);//defini procedure
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.Add("@Foto", SqlDbType.Image, foto.Length).Value = foto;//parametro
                cmdo.Parameters.Add("@idFuncionario", SqlDbType.Int).Value = funcionario.idFuncionario;

                alterar = cmdo.ExecuteNonQuery();//recebe o resultado

                if (alterar >= 1)
                {
                    result = true;
                }
                if (alterar < 1)
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
      
    }


}
