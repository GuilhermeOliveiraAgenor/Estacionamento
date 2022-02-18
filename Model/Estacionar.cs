using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Estacionar
    {

        public int idEstacionar { get; set; }

        public DateTime dataEntrada { get; set; }

        public DateTime dataSaida { get; set; }

        public decimal Preco { get; set; }

        public int Patio { get; set; }

        public int CodigoClienteVeiculo { get; set; }

        public string Status { get; set; }

    }

}
