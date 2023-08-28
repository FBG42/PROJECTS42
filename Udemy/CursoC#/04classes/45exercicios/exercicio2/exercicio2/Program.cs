using exercicio2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            funcionario f = new funcionario();

            Console.Write("Nome: ");
            f.nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {f}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double qtd = double.Parse(Console.ReadLine());
            f.aumentarSalario(qtd);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {f}");
        }
    }
}