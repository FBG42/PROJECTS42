using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, reajuste;
            int porcentual;

            salario = double.Parse(Console.ReadLine());

            if (salario >= 0 && salario <= 400.00)
            {
                porcentual = 15;
                reajuste = salario * 15 / 100;
                novoSalario = salario + reajuste;
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                porcentual = 12;
                reajuste = salario * porcentual / 100;
                novoSalario = salario + reajuste;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                porcentual = 10;
                reajuste = salario * porcentual / 100;
                novoSalario = salario + reajuste;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                porcentual = 7;
                reajuste = salario * porcentual / 100;
                novoSalario = salario + reajuste;
            }
            else if (salario >= 2000.01)
            {
                porcentual = 4;
                reajuste = salario * porcentual / 100;
                novoSalario = salario + reajuste;
            }
            else
            {
                Console.WriteLine("Escreva um salario positivo");
                novoSalario = 0;
                reajuste = 0;
                porcentual = 0;
            }



            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"));
            Console.WriteLine("Em percentual: " + porcentual + " %");
        }
    }
}