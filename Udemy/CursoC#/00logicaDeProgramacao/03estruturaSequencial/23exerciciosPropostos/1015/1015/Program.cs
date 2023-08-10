using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distancia;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            x1 = double.Parse(vet[0]);
            y1 = double.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            
            x2 = double.Parse(vet[0]);
            y2 = double.Parse(vet[1]);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}