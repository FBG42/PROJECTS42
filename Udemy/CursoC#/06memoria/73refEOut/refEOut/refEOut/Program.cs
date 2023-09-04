using System;

namespace refEOut // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ref
            int a = 10;
            calculator.Triple(ref a);
            Console.WriteLine(a);

            // out 
            int b = 10;
            int triple;
            calculator.TripleOut(b, out triple);
            Console.WriteLine(triple);
        }
    }
}