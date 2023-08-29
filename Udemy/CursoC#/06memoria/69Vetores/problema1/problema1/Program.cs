using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mediaDeAltura;
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            mediaDeAltura = 0;
            for (int i = 0; i < n; i++)
            {
                double altura = double.Parse(Console.ReadLine());

                vet[i] = altura;
                mediaDeAltura += vet[i];
            }

            mediaDeAltura /= n;

            Console.WriteLine($"AVERAGE HEIGHT = {mediaDeAltura:F2}");
        }
    }
}