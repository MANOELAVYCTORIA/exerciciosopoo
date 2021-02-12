using System;
using System.Globalization;
namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("NOME: ");
            f1.Nome = Console.ReadLine();
            Console.Write("SALÁRIO: ");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("NOME: ");
            f2.Nome = Console.ReadLine();
            Console.Write("SALÁRIO: ");
            f2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Salário Médio = " + (f1.Salario + f2.Salario)/2);

        }
    }
}
