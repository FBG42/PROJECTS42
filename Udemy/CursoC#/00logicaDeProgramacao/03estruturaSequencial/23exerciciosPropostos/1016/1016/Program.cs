using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Y = int.Parse(Console.ReadLine());

            int total = Y * 2;

            Console.WriteLine(total + " minutos");
        }
    }
}