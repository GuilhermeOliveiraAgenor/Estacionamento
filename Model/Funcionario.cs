using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Funcionario
    {

        public int idFuncionario { get; set; }

        public string primeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string Profissao { get; set; }

        public decimal  Salario { get; set; }

    }
}
