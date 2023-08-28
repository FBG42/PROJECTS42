using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas, colunas;
            int[,] mat;

            string[] s = Console.ReadLine().Split(' ');
            linhas = int.Parse(s[0]);
            colunas = int.Parse(s[1]);
            mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[linhas];

            for ( int i = 0;i < linhas; i++)
            {
                int soma = 0;
                for (int j = 0;j < colunas; j++)
                {
                    soma += mat[i, j];
                }
                vet[i] = soma;
            }

            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}