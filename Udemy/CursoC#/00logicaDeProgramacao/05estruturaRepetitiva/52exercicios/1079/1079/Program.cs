using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;
            int N = int.Parse(Console.ReadLine());
            string[] vet;

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                nota1 = double.Parse(vet[0]);
                nota2 = double.Parse(vet[1]);
                nota3 = double.Parse(vet[2]);

                nota1 *= 2;
                nota2 *= 3;
                nota3 *= 5;

                media = (nota1 + nota2 + nota3) / 10;
                
                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}