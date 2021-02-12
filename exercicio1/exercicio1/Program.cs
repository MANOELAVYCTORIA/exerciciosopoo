using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa Nome, Idade;
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();


            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("NOME: ");
            p1.Nome = Console.ReadLine();
            Console.Write("IDADE: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa: ");
            Console.Write("NOME: ");
            p2.Nome = Console.ReadLine();
            Console.Write("IDADE: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }

        }
    }
}
