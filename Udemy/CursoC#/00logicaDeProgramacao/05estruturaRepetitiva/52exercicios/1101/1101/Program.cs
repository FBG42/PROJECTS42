using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N, maior, menor, soma;

            string[] vet;
            do
            {
                vet = Console.ReadLine().Split(' ');

                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);

                if (M <= 0 || N <= 0)
                {
                    break;
                }

                if (M > N)
                {
                    maior = M;
                    menor = N;
                }
                else
                {
                    maior = N;
                    menor = M;
                }

                soma = 0;
                for (int i = menor; i <= maior; i++)
                {
                    Console.Write($"{i} ");
                    soma += i;
                }

                Console.WriteLine("Sum=" + soma);

            }
            while (true);
        }
    }
}