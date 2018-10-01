using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Gerente : Funcionario
    {

        public Gerente()
        {
        }

        public void Bonificacao()
        {
            Console.WriteLine("Salário com Bonificação: " + (Salario + 10000));
        }

    }
}
