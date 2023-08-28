using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y, N;
            double dividido;

            N = int.Parse(Console.ReadLine());

            string[] vet;

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');

                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    dividido = (double) X / Y;
                    Console.WriteLine(dividido.ToString("F1"));
                }
            }
        }
    }
}