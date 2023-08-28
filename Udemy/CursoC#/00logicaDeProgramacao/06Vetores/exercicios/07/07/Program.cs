using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double media;
            string[] nomes;
            double[] nota1, nota2;
            string[] vet;
            int[] aprovados;

            N = int.Parse(Console.ReadLine());
            nomes = new string[N];
            nota1 = new double[N];
            nota2 = new double[N];
            aprovados = new int[N];


            for(int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');

                nomes[i] = vet[0];
                nota1[i] = double.Parse(vet[1]);
                nota2[i] = double.Parse(vet[2]);
            }

            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0; i < N; ++i)
            {
                media = (nota1[i] + nota2[i]) / 2;
                if (media >= 6)
                {
                    Console.WriteLine($"{nomes[i]}");
                }
            }
        }
    }
}