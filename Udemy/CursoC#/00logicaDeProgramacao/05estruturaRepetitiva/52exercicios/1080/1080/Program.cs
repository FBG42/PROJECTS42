using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maiorValor, valor, posicao;

            maiorValor = 0;
            posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                valor = int.Parse(Console.ReadLine());

                if (valor > maiorValor)
                {
                    maiorValor = valor;
                    posicao = i;
                }
            }

            Console.WriteLine(maiorValor);
            Console.WriteLine(posicao);
        }
    }
}