using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class UsuarioDAO
    {
        private string conectar = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        public DataTable Login(Usuario usuario)
        {
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select Cpf, Senha, Acesso from Usuario where Cpf = @Cpf and Senha = @Senha";
                cmdo.Parameters.Add("@Cpf", SqlDbType.VarChar, 11).Value = usuario.Cpf;//parametros
                cmdo.Parameters.Add("@Senha", SqlDbType.VarChar,50).Value = usuario.Senha;

                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado
                dt.Load(dr);//carrega o dt
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar - O que aconteceu foi o seguinte - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mensagem de erro
            }
            finally
            {
                conn.Close();//fechar conexao
            }

            return dt;
        }

    }
}

