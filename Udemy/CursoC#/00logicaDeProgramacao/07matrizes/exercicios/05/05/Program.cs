using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A, B, C;
            int linhas, colunas;

            string[] vet = Console.ReadLine().Split(' ');

            linhas = int.Parse(vet[0]);
            colunas = int.Parse(vet[1]);

            A = new int[linhas, colunas];
            B = new int[linhas, colunas];
            C = new int[linhas, colunas];

            for ( int i = 0; i < linhas; i++ )
            {
                vet = Console.ReadLine().Split(' ');

                for ( int j = 0; j < colunas; j++ )
                {
                    A[i, j] = int.Parse(vet[j]);
                }
            }

            for (int i = 0; i < linhas; i++)
            {
                vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < colunas; j++)
                {
                    B[i, j] = int.Parse(vet[j]);
                }
            }

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}