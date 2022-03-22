using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    internal class Endereco
    {
        public string rua { get;  set; }
        public string numero { get;  set; }
        public string complemento { get;  set; }
        public string cep { get;  set; }

        public Endereco(string rua, string numero, string complemento, string cep)
        {
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.cep = cep;
        }
    }
}
