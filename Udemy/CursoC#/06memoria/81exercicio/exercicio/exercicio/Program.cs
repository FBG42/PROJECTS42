using System;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas, colunas, X;
            int[,] mat;

            string[] vet = Console.ReadLine().Split(' ');

            linhas = int.Parse(vet[0]);
            colunas = int.Parse(vet[1]);

            mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            X = int.Parse(Console.ReadLine());

            for (int i = 0;i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (mat[i, j] == X)
                    {
                        Console.WriteLine($"Position: {i},{j}");

                        if (j > 0) Console.WriteLine($"Left: {mat[i, j - 1 ]}");
                        if (j < colunas - 1) Console.WriteLine($"Right: {mat[i, j + 1]}");
                        if (i < linhas - 1) Console.WriteLine($"Down: {mat[i + 1, j]}");
                        if (i > 0) Console.WriteLine($"Up: {mat[i - 1, j]}");
                    }
                }
            }
        }
    }
}