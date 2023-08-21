using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] vet = Console.ReadLine().Split(' ');
            
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            for (int i = 1; i <= Y; i++)
            {
                if (i % X != 0)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}