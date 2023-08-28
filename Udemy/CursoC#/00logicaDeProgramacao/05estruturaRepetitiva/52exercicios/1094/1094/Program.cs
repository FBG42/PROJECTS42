using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total, totalCoelhos, totalRatos, totalSapos, numeroDeCobaias;
            double percentualCoelhos, percentualRatos, percentualSapos;
            char tipoDaCobaia;

            int N = int.Parse(Console.ReadLine());
            string[] vet;

            totalCoelhos = 0;
            totalRatos = 0;
            totalSapos = 0;

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');

                numeroDeCobaias = int.Parse(vet[0]);
                tipoDaCobaia = char.Parse(vet[1]);

                if (tipoDaCobaia == 'C')
                {
                    totalCoelhos += numeroDeCobaias;
                }
                else if (tipoDaCobaia == 'R')
                {
                    totalRatos += numeroDeCobaias;
                }
                else if (tipoDaCobaia == 'S')
                {
                    totalSapos += numeroDeCobaias;
                }
            }

            total = totalCoelhos + totalRatos + totalSapos;

            percentualCoelhos = (double) totalCoelhos / total * 100;
            percentualRatos = (double) totalRatos / total * 100;
            percentualSapos = (double) totalSapos / total * 100;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {totalCoelhos}");
            Console.WriteLine($"Total de ratos: {totalRatos}");
            Console.WriteLine($"Total de sapos: {totalSapos}");
            Console.WriteLine($"Percentual de coelhos: {percentualCoelhos:F2} %");
            Console.WriteLine($"Percentual de ratos: {percentualRatos:F2} %");
            Console.WriteLine($"Percentual de sapos: {percentualSapos:F2} %");

        }
    }
}