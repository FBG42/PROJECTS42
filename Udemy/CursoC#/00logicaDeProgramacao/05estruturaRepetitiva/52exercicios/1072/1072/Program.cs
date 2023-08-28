using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, X, numbersIn, numbersOut;

            N = int.Parse(Console.ReadLine());

            numbersOut = 0;
            numbersIn = 0;

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    numbersIn++;
                }
                else if (X < 10 || X > 20)
                {
                    numbersOut++;
                }
            }

            Console.WriteLine($"{numbersIn} in");
            Console.WriteLine($"{numbersOut} out");
        }
    }
}