using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            // Ordena os lados em ordem decrescente.
            (A, B) = A >= B ? (A, B) : (B, A);
            (A, C) = A >= C ? (A, C) : (C, A);
            (B, C) = B >= C ? (B, C) : (C, B);

            // Verifica todas as possíveis classificações e imprime apropriada.
            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (A * A == B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (A * A > B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (A * A < B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (A == B && A != C || A == C && A != B || B == C && B != A)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
            }
        }
    }
}