using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;

            double salarioFixo, vendasEfetuadas, comissao, total;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine());
            vendasEfetuadas = double.Parse(Console.ReadLine());

            comissao = (vendasEfetuadas * 15) / 100;

            total = salarioFixo + comissao;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
        }
    }
}