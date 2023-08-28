using System;
using System.Reflection.Metadata;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prev, prevPrev, z;
            int N = int.Parse(Console.ReadLine());

            prevPrev = 0;
            prev = 1;

            for (int i = 0; i < N; i++)
            {
                Console.Write(prevPrev);

                if (i < N - 1)
                {
                    Console.Write(' ');
                }

                int current = prevPrev + prev;
                prevPrev = prev;
                prev = current;
            }

            Console.WriteLine();
        }
    }
}