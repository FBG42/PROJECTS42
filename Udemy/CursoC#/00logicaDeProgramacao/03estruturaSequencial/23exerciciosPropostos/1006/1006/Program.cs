using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, mediaPonderada;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            A = A * 2;
            B = B * 3;
            C = C * 5;

            mediaPonderada = (A + B + C) / 10;

            Console.WriteLine("MEDIA = " + mediaPonderada.ToString("F1"));
        }
    }
}