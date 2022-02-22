using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        public int idUsuario { get; set; }

        public string Cpf { get; set; }

        public string Senha { get; set; }

        public int Acesso { get; set; }

        public int codigoFuncionario { get; set; }
    }
}
