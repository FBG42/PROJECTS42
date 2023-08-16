using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x, total;

            N = int.Parse(Console.ReadLine());
            total = 0;

            for (int i = 0; i < N; i++)
            {
                x = int.Parse(Console.ReadLine()) ;
                total += x;
            }

            Console.WriteLine(total);
        }
    }
}