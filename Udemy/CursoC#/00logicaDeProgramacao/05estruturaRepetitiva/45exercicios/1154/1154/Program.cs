using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, contador, total;
            double media;

            idade = int.Parse(Console.ReadLine());

            contador = 0;
            total = 0;

            while (idade > 0)
            {
                total += idade;
                contador++;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) total / contador;

            Console.WriteLine(media.ToString("F2"));
        }
    }
}