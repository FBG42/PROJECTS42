using referencia;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            point p;

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new point();
            Console.WriteLine(p);
        }
    }
}