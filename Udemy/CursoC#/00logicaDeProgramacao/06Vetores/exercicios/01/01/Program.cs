using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, index;
            double maior;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            maior = 0;
            index = 0;
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i]);

                if (vet[i] > maior)
                {
                    maior = vet[i];
                    index = i;
                } 
            }

            Console.WriteLine(maior.ToString("F1"));
            Console.WriteLine(index);
        }
    }
}