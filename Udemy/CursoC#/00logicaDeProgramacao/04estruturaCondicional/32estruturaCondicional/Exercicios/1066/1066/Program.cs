using System;
using System.Linq.Expressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nmr1, nmr2, nmr3, nmr4, nmr5, nmr6, totalDePares, totalDeImpares, totalDePositivos, totalDeNegativos;

            nmr1 = double.Parse(Console.ReadLine());
            nmr2 = double.Parse(Console.ReadLine());
            nmr3 = double.Parse(Console.ReadLine());
            nmr4 = double.Parse(Console.ReadLine());
            nmr5 = double.Parse(Console.ReadLine());

            double[] numeros = { nmr1, nmr2, nmr3, nmr4, nmr5 };

            totalDePositivos = 0;
            totalDePares = 0;
            totalDeImpares = 0;
            totalDeNegativos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0 )
                {
                    totalDePositivos++;
                }
                if (numeros[i] < 0 )
                {
                    totalDeNegativos++;
                }
                if (numeros[i] % 2 == 0)
                {
                    totalDePares++;
                }
                if (numeros[i] % 2 != 0 )
                {
                    totalDeImpares++;
                }

            }

            Console.WriteLine($"{totalDePares} valor(es) par(es)");
            Console.WriteLine($"{totalDeImpares} valor(es) impar(es)");
            Console.WriteLine($"{totalDePositivos} valor(es) positivo(s)");
            Console.WriteLine($"{totalDeNegativos} valor(es) negativo(s)");
        }
    }
}