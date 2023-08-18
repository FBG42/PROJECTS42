using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nmr1, nmr2, nmr3;
            int N = int.Parse(Console.ReadLine());

            nmr1 = 1;
            nmr2 = 2;
            nmr3 = 3;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{nmr1} {nmr2} {nmr3} PUM");
                nmr1 += 4;
                nmr2 += 4;
                nmr3 += 4;
            }
        }
    }
}