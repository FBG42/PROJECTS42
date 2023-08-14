using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, perimetro, area;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            if (A + B > C && A + C > B && B + C > A)
            {
                perimetro = A + B + C;
                Console.WriteLine($"Perimetro = {perimetro:F1}");
            }
            else
            {
                area = (A + B) * C / 2;
                Console.WriteLine($"Area = {area:F1}");
            }
        }
    }
}