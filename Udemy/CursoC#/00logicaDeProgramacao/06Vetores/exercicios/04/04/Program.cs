using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double total, media;
            double[] numerosReais;

            N = int.Parse(Console.ReadLine());
            numerosReais = new double[N];
            string[] vet = Console.ReadLine().Split(' ');

            total = 0;
            for (int i = 0; i < N; i++)
            {
                numerosReais[i] = double.Parse(vet[i]);
                total += double.Parse(vet[i]);
            }

            media = total / N;
            Console.WriteLine(media.ToString("F3"));

            for ( int i = 0; i < N; ++i )
            {
                if (double.Parse(vet[i]) < media)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}