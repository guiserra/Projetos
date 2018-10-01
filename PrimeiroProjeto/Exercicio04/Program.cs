using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario func = new Funcionario();
            Gerente ger = new Gerente();
            Supervisor sup = new Supervisor();
            Vendedor vend = new Vendedor();

            ger.Nome = "João";
            ger.Idade = 53;
            ger.Salario = 6300;

            sup.Nome = "Carlos";
            sup.Idade = 46;
            sup.Salario = 4600;

            vend.Nome = "Alberto";
            vend.Idade = 33;
            vend.Salario = 3700;

            Console.WriteLine("----------- Gerente ------------");
            Console.WriteLine("Nome: " + ger.Nome + "\nIdade: " + ger.Idade + "\nSalário: " + ger.Salario);
            ger.Bonificacao();

            Console.WriteLine("");
            Console.WriteLine("---------- Supervisor ----------");
            Console.WriteLine("Nome: " + sup.Nome + "\nIdade: " + sup.Idade + "\nSalário: " + sup.Salario);
            sup.Bonificacao();

            Console.WriteLine("");
            Console.WriteLine("----------- Vendedor -----------");
            Console.WriteLine("Nome: " + vend.Nome + "\nIdade: " + vend.Idade + "\nSalário: " + vend.Salario);
            vend.Bonificacao();

            Console.ReadKey();

        }
    }
}
