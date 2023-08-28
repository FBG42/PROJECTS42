using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] A;
            double soma, media;

            N = int.Parse(Console.ReadLine());
            A = new double[N];

            soma = 0.0;
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(s[i]);
                Console.Write(A[i].ToString("F1") + " ");
                soma += A[i];
            }
            Console.WriteLine();

            media = soma / N;

            Console.WriteLine(soma.ToString("F2"));
            Console.WriteLine(media.ToString("F2"));
        }
    }
}