using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int N = int.Parse(Console.ReadLine());


            for (int i = 0; i < N; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (x % 2 == 0)
                {
                    Console.Write("EVEN ");
                }
                else
                {
                    Console.Write("ODD ");
                }

                if (x > 0)
                {
                    Console.WriteLine("POSITIVE");
                }
                else if (x < 0)
                {
                    Console.WriteLine("NEGATIVE");
                }
            }
        }
    }
}