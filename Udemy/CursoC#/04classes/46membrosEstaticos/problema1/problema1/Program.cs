using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = circunferencia(raio);
            double vol = volume(raio);

            Console.WriteLine("Circunferência " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + vol.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2"));
        }

        static double circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
    }
}