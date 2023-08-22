using System;
using System.Drawing;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] mat;

            N = int.Parse(Console.ReadLine());
            mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            int cont = 0;
            for (int i = 0; i < N; ++i)
            {
                for (int j = i + 1; j < N; j++)
                {
                    cont += mat[i, j];
                }
            }

            Console.WriteLine(cont);
        }
    }
}