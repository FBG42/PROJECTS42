using System;

namespace exercicio1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pessoa A, B;

            A = new pessoa();
            B = new pessoa();

            Console.WriteLine("Dados da primeira pessoa:");

            A.nome = Console.ReadLine();
            A.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");

            B.nome = Console.ReadLine();
            B.idade = int.Parse(Console.ReadLine());

            if (A.idade > B.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {A.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {B.nome}");
            }
        }
    }
}