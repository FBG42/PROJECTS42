using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nmr1, nmr2, nmr3;
            int N = int.Parse(Console.ReadLine());

            nmr1 = 0;
            nmr2 = 0;
            nmr3 = 0;
            for (int i = 1; i <= N; i++)
            {
                nmr1 = i;
                nmr2 = nmr1 * nmr1;
                nmr3 = nmr1 * nmr2;
               Console.WriteLine($"{nmr1} {nmr2} {nmr3}");
            }
        }
    }
}