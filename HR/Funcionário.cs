using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    internal class Funcionário
    {
        public int id { get;  set; }
        public string nome { get;  set; }
        public string cpf { get;  set; }
        public Endereco endereco { get;  set; }

        public Funcionário(int id, string nome, string cpf, Endereco endereco)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
        }
    }
}
