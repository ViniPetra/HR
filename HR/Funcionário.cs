using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    internal class Funcionario
    {
        public int id { get;  private set; }
        public string nome { get;  private set; }
        public string cpf { get;  private set; }
        public Endereco endereco { get;  private set; }

        public Funcionario(int id, string nome, string cpf, Endereco endereco)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
        }
    }
}
