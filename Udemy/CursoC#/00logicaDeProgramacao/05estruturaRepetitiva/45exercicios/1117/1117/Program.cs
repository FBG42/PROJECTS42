using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double avaliacaoUm, avaliacaoDois, media;

            avaliacaoUm = double.Parse(Console.ReadLine());

            while (avaliacaoUm < 0.0 || avaliacaoUm > 10.0)
            {
                Console.WriteLine("nota invalida");
                avaliacaoUm = double.Parse(Console.ReadLine());
            }

            avaliacaoDois = double.Parse(Console.ReadLine());

            while (avaliacaoDois < 0.0 || avaliacaoDois > 10.0)
            {
                Console.WriteLine("nota invalida");
                avaliacaoDois = double.Parse(Console.ReadLine());
            }

            media = (avaliacaoUm + avaliacaoDois) / 2;

            Console.WriteLine("media = " + media.ToString("F2"));
        }
    }
}