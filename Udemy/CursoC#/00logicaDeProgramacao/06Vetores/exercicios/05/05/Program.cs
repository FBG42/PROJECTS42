using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, totalPares, quantidadePares;
            double media;

            N = int.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');

            totalPares = 0;
            quantidadePares = 0;
            for (int i = 0; i < N; i++)
            {
                if (int.Parse(vet[i]) % 2 == 0)
                {
                    totalPares += int.Parse(vet[i]);
                    quantidadePares++;
                }
            }

            media = (double) totalPares / quantidadePares;

            Console.WriteLine(media.ToString("F1"));
        }
    }
}