using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, maiorAB, maior;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;

            maior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;


            Console.WriteLine(maior + " eh o maior");
        }
    }
}