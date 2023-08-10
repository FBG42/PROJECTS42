using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            pi = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C= double.Parse(vet[2]);

            areaTriangulo = A * C / 2;
            areaCirculo = pi * Math.Pow(C, 2);
            areaTrapezio = (A + B) * C / 2;
            areaQuadrado = B * B;
            areaRetangulo = A * B;


            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"));
        }
    }
}