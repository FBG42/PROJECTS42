using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDoFuncionaro, horasTrabalhadas;
            double recebePorHora, salario;

            numeroDoFuncionaro = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            recebePorHora = double.Parse(Console.ReadLine());
            salario = recebePorHora * horasTrabalhadas;


            Console.WriteLine("NUMBER = " + numeroDoFuncionaro);
            Console.WriteLine("SALARY = U$ " +  salario.ToString("F2"));
        }
    }
}