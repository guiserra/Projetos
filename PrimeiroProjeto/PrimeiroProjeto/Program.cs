using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando a lista do objeto Pessoa
            List<Pessoa> listaPessoa = new List<Pessoa>();

            //variaveis para controlar a condição de pessoa mais velha
            int maior = 0;
            int posicaoMaior = 0;

            //criando a variavel para o menu
            String s1 = null;

            //adicionando objetos a lista
            listaPessoa.Add(new Pessoa("João",15));
            listaPessoa.Add(new Pessoa("Leandro",21));
            listaPessoa.Add(new Pessoa("Paulo",17));
            listaPessoa.Add(new Pessoa("Jessica",18));
            
            while(s1 != "5")
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("\n " +
                    "Escolha uma opção \n"
                + "\n 1 - Exibir a Lista"
                + "\n 2 - Exibir a pessoa mais velha"
                + "\n 3 - Exibir maiores de 18 anos"
                + "\n 4 - Verificar se existe o nome Jessica"
                + "\n 5 - Sair");
                
                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------");

                s1 = Console.ReadLine().ToString();

                switch (s1)
                {
                    case "1":

                        Console.WriteLine(" ");

                        //exibindo a lista
                        foreach (Pessoa p in listaPessoa)
                        {
                            Console.WriteLine(p.Nome + " " + p.Idade + " anos");
                        }

                        Console.WriteLine(" ");

                        break;
                    case "2":
                        
                        Console.WriteLine(" ");

                        //condição para exibir a pessoa mais velha
                        for (int i = 0; i < listaPessoa.Count; i++)
                        {
                            //se o indice for igual a 0 entra no if
                            if (i == 0) //sempre true
                            {
                                //atribuindo a idade da primeira pessoa a variavel maior
                                maior = listaPessoa[0].Idade;
                            }
                            else if (listaPessoa[i].Idade > maior) //verificando se as outras idades sao maiores do que a idade atribuida anteriormente
                            {
                                //se condição for verdadeira atribui a nova idade para a variavel maior
                                maior = listaPessoa[i].Idade;
                                posicaoMaior = i;
                            }
                        }

                        //exibindo a pessoa mais velha e sua idade
                        Console.WriteLine(" ");
                        Console.WriteLine("A pessoa mais velha é " + listaPessoa[posicaoMaior].Nome + " e tem " + listaPessoa[posicaoMaior].Idade + " anos.");

                        Console.WriteLine(" ");

                        break;
                    case "3":
                        
                        Console.WriteLine(" ");

                        //exibindo a quantidade de pessoas dentro da lista antes da condição
                        Console.WriteLine(listaPessoa.Count + " pessoas na lista antes da condição");
                        Console.WriteLine(" ");

                        //condição para verificar quem é menor de 18 anos
                        for (int i = 0; i < listaPessoa.Count; i++)
                        {
                            if (listaPessoa[i].Idade < 18)
                            {
                                //removendo quem for menor de 18 anos
                                listaPessoa.Remove(listaPessoa[i]);
                            }
                        }

                        //exibindo somente pessoas com idade igual ou maior que 18 anos
                        foreach (Pessoa p in listaPessoa)
                        {
                            Console.WriteLine(p.Nome + " " + p.Idade + " anos");
                        }

                        //exibindo a quantidade de pessoas dentro da lista depois da condição
                        Console.WriteLine(" ");
                        Console.WriteLine(listaPessoa.Count + " pessoas na lista depois da condição");

                        Console.WriteLine(" ");

                        break;
                    case "4":

                        Console.WriteLine(" ");

                        for (int i = 0; i < listaPessoa.Count; i++)
                        {
                            //verificando se existe o nome Jessica dentro da lista
                            if (listaPessoa[i].Nome == "Jessica")
                            {
                                //exibindo nome e idade da Jessica
                                Console.WriteLine(listaPessoa[i].Nome + " tem " + listaPessoa[i].Idade + " anos");
                            }
                        }

                        Console.WriteLine(" ");

                        break;
                    case "5":

                        Console.Clear();
                        
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Número Incorreto");
                        Console.WriteLine(" ");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
