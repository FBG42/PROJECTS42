using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, totalPares;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            totalPares = 0;
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);

                if (vet[i] % 2 == 0)
                {
                    Console.Write($"{vet[i]} ");
                    totalPares++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(totalPares);
        }
    }
}