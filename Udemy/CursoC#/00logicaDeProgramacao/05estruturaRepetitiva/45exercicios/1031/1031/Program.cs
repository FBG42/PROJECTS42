using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int golsInter, golsGremio, vitoriasInter, vitoriasGremio, empates, totalDeGrenais, novoCalculo;
            string[] vet;

            novoCalculo = 0;
            vitoriasInter = 0;
            vitoriasGremio = 0;
            empates = 0;
            totalDeGrenais = 0;

            while (novoCalculo != 2)
            {
                vet = Console.ReadLine().Split(' ');

                golsInter = int.Parse(vet[0]);
                golsGremio = int.Parse(vet[1]);

                if (golsInter > golsGremio)
                {
                    vitoriasInter++;
                }
                else if (golsInter < golsGremio)
                {
                    vitoriasGremio++;
                }
                else
                {
                    empates++;
                }
                totalDeGrenais++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());

                while (novoCalculo < 1 || novoCalculo > 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine($"{totalDeGrenais} grenais");
            Console.WriteLine($"Inter:{vitoriasInter}");
            Console.WriteLine($"Gremio:{vitoriasGremio}");
            Console.WriteLine($"Empates:{empates}");

            if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
}