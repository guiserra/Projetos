using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Salario { get; set; }

        public void bonificacao()
        {
            Console.WriteLine(Salario);
        }
    }
}
