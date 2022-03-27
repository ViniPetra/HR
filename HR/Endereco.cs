using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Endereco
    {
        public string rua { get;  private set; }
        public string numero { get; private set; }
        public string complemento { get; private set; }
        public string cep { get; private set; }

        public Endereco(string rua, string numero, string complemento, string cep)
        {
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.cep = cep;
        }
    }
}
