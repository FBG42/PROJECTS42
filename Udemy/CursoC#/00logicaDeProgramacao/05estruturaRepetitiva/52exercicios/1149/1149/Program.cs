using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, N, soma;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            N = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                if (int.Parse(vet[i]) > 0)
                {
                    N = int.Parse(vet[i]);
                }
            }

            soma = 0;
            for (int j = 0; j < N; j++)
            {
                soma += A + j;
            }

            Console.WriteLine(soma);
        }
    }
}