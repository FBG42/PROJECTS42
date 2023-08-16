using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                int sum = 0;
                int count = 0;

                if (x % 2 != 0)
                {
                    x++;
                }

                while (count < 5)
                {
                    sum += x;
                    x += 2;
                    count++;
                }

                Console.WriteLine(sum);

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}