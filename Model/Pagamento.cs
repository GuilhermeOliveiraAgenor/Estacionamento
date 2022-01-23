using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pagamento
    {
        public int idPagamento { get; set; }
        public decimal Preco { get; set; }
        public int CodigoFormaPagamento { get; set; }
        public int codigoEstacionar { get; set; }

    }
}
