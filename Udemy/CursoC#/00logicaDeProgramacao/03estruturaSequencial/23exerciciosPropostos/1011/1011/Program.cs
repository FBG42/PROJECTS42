using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int R;
            double pi, volume;

            pi = 3.14159;
            R = int.Parse(Console.ReadLine());
            volume = (double) (4.0 / 3) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
        }
    }
}