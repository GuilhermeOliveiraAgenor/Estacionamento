using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamento.editarPedidos;
using Estacionamento.Entrada;
using Estacionamento.Funcionario;
using Estacionamento.Funcionario.Relatorio;
using Estacionamento.Login;
using Estacionamento.Menu;
using Estacionamento.Saida;
using Estacionamento.Usuarios;

namespace Estacionamento
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
