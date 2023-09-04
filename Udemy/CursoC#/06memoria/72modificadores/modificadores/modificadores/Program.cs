using System;

namespace modificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int s1 = calculator.Sum(2, 3);
            //int s2 = calculator.Sum(2, 4, 3);
            int s1 = calculator.Sum(2, 3);
            int s2 = calculator.Sum(2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}