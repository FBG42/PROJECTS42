using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int J1, J2, J3;

            J1 = 7;
            J2 = 6;
            J3 = 5;
            for (int i = 1; i <= 10; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine($"I={i} J={J1}");
                    Console.WriteLine($"I={i} J={J2}");
                    Console.WriteLine($"I={i} J={J3}");

                    J1 += 2;
                    J2 += 2;
                    J3 += 2;
                }
            }
        }
    }
}