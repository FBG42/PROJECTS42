using System;
using System.Linq.Expressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nmr1, nmr2, nmr3, nmr4, nmr5, nmr6, totalDePositivios;

            nmr1 = double.Parse(Console.ReadLine());
            nmr2 = double.Parse(Console.ReadLine());
            nmr3 = double.Parse(Console.ReadLine());
            nmr4 = double.Parse(Console.ReadLine());
            nmr5 = double.Parse(Console.ReadLine());
            nmr6 = double.Parse(Console.ReadLine());

            double[] numeros = { nmr1, nmr2, nmr3, nmr4, nmr5, nmr6 };

            totalDePositivios = 0;

            for (int i = 0;  i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    totalDePositivios++;
                }
            }

            Console.WriteLine(totalDePositivios + " valores positivos");
        }
    }
}