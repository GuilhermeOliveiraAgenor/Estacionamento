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
    public class nivelAcessoDAO
    {
        private string conectar = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        public List<nivelAcesso> carregarAcesso()
        {
            List<nivelAcesso> nivel = new List<nivelAcesso>();
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand cmdo = new SqlCommand();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();//abrir conexao
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;//defini text
                cmdo.CommandText = "select *from nivelAcesso";

                SqlDataReader dr = cmdo.ExecuteReader();//recebe o resultado

                while (dr.Read())//recebe as informaçoes
                {
                    nivel.Add(new nivelAcesso()
                    {
                        idNivelAcesso = Convert.ToInt32(dr["idNivelAcesso"].ToString()),//adiciona as informaçoes
                        Nivel = dr["Nivel"].ToString()
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
            return nivel;
        }
    }
}
