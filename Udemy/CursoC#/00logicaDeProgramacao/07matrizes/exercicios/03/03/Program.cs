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

            for (int i = 0; i < N; ++i)
            {
                int maior = 0;

                for (int j = 0; j < N; ++j)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }

                Console.WriteLine(maior);
            }
        }
    }
}