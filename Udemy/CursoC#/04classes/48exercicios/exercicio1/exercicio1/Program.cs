using exercicio1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double haComprar = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.dolarParaReal(cotacao, haComprar):F2}");
        }
    }
}