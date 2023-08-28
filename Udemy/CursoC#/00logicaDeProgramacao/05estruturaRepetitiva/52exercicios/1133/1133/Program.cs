using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y, maior, menor;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                maior = X;
                menor = Y;
            }
            else
            {
                maior = Y;
                menor = X;
            }

            for (int i = menor + 1; i < maior; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}