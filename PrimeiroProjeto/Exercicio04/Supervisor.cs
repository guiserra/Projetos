using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Supervisor : Funcionario
    {

        public Supervisor()
        {

        }

        public void Bonificacao()
        {
            Console.WriteLine("Salário com Bonificação: " + (Salario + 5000));
        }

    }
}
