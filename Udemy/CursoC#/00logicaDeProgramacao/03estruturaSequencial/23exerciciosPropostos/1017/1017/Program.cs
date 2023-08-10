using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempoGasto, velocidadeMedia, total;

            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            total = velocidadeMedia * tempoGasto / 12;

            Console.WriteLine(total.ToString("F3"));
        }
    }
}