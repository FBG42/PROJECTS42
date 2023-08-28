using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine());

                F = 9 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1"));
                Console.WriteLine("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());
            } 
            while (repetir == 's');
        }
    }
}