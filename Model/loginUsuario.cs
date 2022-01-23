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

        public static void login(string cpf, string senha)
        {
            cpfUsuario = cpf;
            senhaUsuario = senha;
        }

        public static void logout()
        {

            cpfUsuario = null;
            senhaUsuario = null;

        }
        public static string getUsuario()
        {
            return "Cpf: " + cpfUsuario + "\nSenha: " + senhaUsuario;
        }

        public static string getCpf()
        {
            return cpfUsuario;
        }



    }
}

