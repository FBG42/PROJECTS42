using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas, colunas;
            int[,] mat;

            string[] vet = Console.ReadLine().Split(' ');

            linhas = int.Parse(vet[0]);
            colunas = int.Parse(vet[1]);

            mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS");
            for (int i = 0;i < linhas; i++)
            {
                for (int j = 0;j < colunas; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}