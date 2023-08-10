using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, total;

            X = int.Parse(Console.ReadLine()); 
            Y = double.Parse(Console.ReadLine());

            total = X / Y;

            Console.WriteLine(total.ToString("F3") + " km/l");
        }
    }
}