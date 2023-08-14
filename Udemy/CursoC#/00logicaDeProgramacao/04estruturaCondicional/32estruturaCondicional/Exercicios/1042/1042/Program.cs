using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);
            int num3 = int.Parse(vet[2]);

            int[] numeros = { num1, num2, num3 };

            Array.Sort(numeros);

            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);

            Console.WriteLine();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}