using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class loginUsuario
    {
        static string cpfUsuario;
        static string senhaUsuario;
        static int nivelUsuario;

        public static void login(string cpf, string senha, int nivel)
        {
            cpfUsuario = cpf;
            senhaUsuario = senha;
            nivelUsuario = nivel;
        }

        public static void logout()
        {
            cpfUsuario = null;
            senhaUsuario = null;
            nivelUsuario = 0;
        }
        public static string getUsuario()
        {
            return cpfUsuario + senhaUsuario;
        }
        public static string getCpf()
        {
            return cpfUsuario;
        }
        public static string getNivel() 
        {
            return Convert.ToString(nivelUsuario);
        }
    }
}

