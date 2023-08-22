using System;

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

            int[] vet2 = new int[N];

            for (int i = 0; i < N; ++i)
            {
                int cont = 0;

                for (int j = 0; j < N; ++j)
                {
                    cont += mat[i, j];
                }

                vet2[i] = cont;
                Console.WriteLine(cont);
            }
        }
    }
}