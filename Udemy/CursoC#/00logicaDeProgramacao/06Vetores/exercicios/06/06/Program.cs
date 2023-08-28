using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, maisVelha, index;
            string[] nomes;
            int[] idades;
            string[] vet;

            N = int.Parse(Console.ReadLine());

            nomes = new string[N];
            idades = new int[N];

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');

                nomes[i] = vet[0];
                idades[i] = int.Parse(vet[1]);
            }

            maisVelha = 0;
            index = 0;
            for (int i = 0;i < N; i++)
            {
                if (idades[i] > maisVelha)
                {
                    maisVelha = idades[i];
                    index = i;
                }
            }

            Console.WriteLine($"Pessoa mais velha: {nomes[index]}");
        }
    }
}