using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine());

            soma = 0.0;
            cont = 0;
            while (idade >= 0)
            {
                soma += idade;
                cont++;
                idade = double.Parse(Console.ReadLine());
            }

            if (cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2"));
            }
        }
    }
}