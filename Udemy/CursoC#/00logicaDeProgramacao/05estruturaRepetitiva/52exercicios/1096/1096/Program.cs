using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"I={i} J=7");
                    Console.WriteLine($"I={i} J=6");
                    Console.WriteLine($"I={i} J=5");
                }
            }
        }
    }
}