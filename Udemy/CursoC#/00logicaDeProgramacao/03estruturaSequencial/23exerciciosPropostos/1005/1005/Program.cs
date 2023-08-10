using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, mediaPonderada;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            A = A * 3.5;
            B = B * 7.5;

            mediaPonderada = (A + B) / 11;

            Console.WriteLine("MEDIA = " + mediaPonderada.ToString("F5"));
        }
    }
}