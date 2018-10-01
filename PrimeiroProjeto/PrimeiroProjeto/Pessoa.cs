using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome,int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Pessoa()
        {
        }
    }
}
