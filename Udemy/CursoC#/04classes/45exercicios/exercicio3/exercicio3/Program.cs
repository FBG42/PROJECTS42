using exercicio3;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            aluno a = new aluno();

            Console.Write("Nome do aluno: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.nota1 = double.Parse(Console.ReadLine());
            a.nota2 = double.Parse(Console.ReadLine());
            a.nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"NOTA FINAL = {a.notaFinal():F2}");
            a.aprovadoOuReprovado();
        }
    }
}