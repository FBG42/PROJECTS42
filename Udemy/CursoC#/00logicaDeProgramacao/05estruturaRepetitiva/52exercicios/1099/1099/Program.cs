using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y, maior, menor, soma;
            string[] vet;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');

                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);


                if (X > Y)
                {
                    maior = X;
                    menor = Y;
                }
                else
                {
                    maior = Y;
                    menor = X;
                }

                soma = 0;
                for (int j = menor + 1; j < maior; j++)
                {
                    if (j % 2 != 0 )
                    {
                        soma += j;
                    } 
                }

                Console.WriteLine(soma);
            }
        }
    }
}