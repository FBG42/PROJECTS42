using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y, totalMultiplos;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            int menor = X;
            int maior = Y;

            if (X > Y)
            {
                menor = Y;
                maior = X;
            }

            totalMultiplos = 0;

            for (int i = menor;i <= maior;i++)
            {
                if (i % 13 != 0)
                {
                    totalMultiplos += i;
                }
            }

            Console.WriteLine(totalMultiplos);
        }
    }
}