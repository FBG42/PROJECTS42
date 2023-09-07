using System;

namespace exercicioResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalOfNegatives;
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            totalOfNegatives = 0;
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                    if (mat[i, j] < 0)
                    {
                        totalOfNegatives++;
                    }
                }
            }


            Console.WriteLine("Main diagonal:");
            for(int i = 0;i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Negative numbers: " + totalOfNegatives);
        }
    }
}