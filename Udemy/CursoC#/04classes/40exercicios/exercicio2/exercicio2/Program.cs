using System;

namespace exercicio2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mediaSalarial;
            funcionario A, B;

            A = new funcionario();
            B = new funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            A.nome = Console.ReadLine();
            Console.Write("Salário: ");
            A.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            B.nome = Console.ReadLine();
            Console.Write("Salário: ");
            B.salario = double.Parse(Console.ReadLine());


            mediaSalarial = (A.salario + B.salario) / 2;

            Console.WriteLine("Salário médio =" +  mediaSalarial.ToString("F2"));
        }
    }
}