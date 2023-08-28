using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] vetor1;
            int[] vetor2;
            int[] vetor3;

            N = int.Parse(Console.ReadLine());

            vetor1 = new int[N];
            vetor2 = new int[N];
            vetor3 = new int[N];

            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');


            for (int i = 0; i < N; i++)
            {
                vetor1[i] = int.Parse(vet1[i]);
                vetor2[i] = int.Parse(vet2[i]);
            }

            for (int i = 0; i < N; i++)
            {
                vetor3[i] = vetor1[i] + vetor2[i];
                Console.Write($"{vetor3[i]} ");
            }
            Console.WriteLine();
        }
    }
}