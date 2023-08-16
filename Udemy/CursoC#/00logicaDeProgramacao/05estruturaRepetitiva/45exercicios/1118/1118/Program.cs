using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int novoCalculo = 0;
            while (novoCalculo != 2)
            {
                double avaliacaoUm, avaliacaoDois, media;

                avaliacaoUm = double.Parse(Console.ReadLine());

                while (avaliacaoUm < 0 || avaliacaoUm > 10)
                {
                    Console.WriteLine("nota invalida");
                    avaliacaoUm = double.Parse(Console.ReadLine());
                }

                avaliacaoDois = double.Parse(Console.ReadLine());

                while (avaliacaoDois < 0 || avaliacaoDois > 10)
                {
                    Console.WriteLine("nota invalida");
                    avaliacaoDois = double.Parse(Console.ReadLine());
                }

                media = (avaliacaoUm + avaliacaoDois) / 2;

                Console.WriteLine($"media = {media:F2}");

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());

                while (novoCalculo < 1 || novoCalculo > 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}