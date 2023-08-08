using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y;
            x = 5;
            y = 2 * x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            //double b, B, h, area;
            //b = 6.0;
            //B = 8.0;
            //h = 5.0;
            //area = (b + B) / 2.0 * h;
            //Console.WriteLine(area);

            //int a, b;
            //double resultado;
            //a = 5;
            //b = 2;
            //resultado = (double) a / b;
            //Console.WriteLine(resultado);

            double a;
            int b;
            a = 5.0;
            b = (int) a;
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}