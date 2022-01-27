using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Funcionarios
    {

        public int idFuncionario { get; set; }
        public string primeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Profissao { get; set; }
        public decimal  Salario { get; set; }
        public byte[] foto { get; set; }
        public string caminhoFoto { get; set; }

        public byte[] GetFoto(string caminhoFoto)
        {
            byte[] foto;//onde o arquivo vai ser armazenado

            using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))//abre o local do arquivo e le o arquivo
            {
                using (var reader = new BinaryReader(stream))
                {
                    foto = reader.ReadBytes((int)stream.Length);//carrega o tamanho do arquivo
                }
            }
            return foto;     
        }

    }
}
