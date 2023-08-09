using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine());
            comprimento = double.Parse(Console.ReadLine());
            precoMetroQuadrado = double.Parse(Console.ReadLine());

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;


            Console.WriteLine("AREA = " + area.ToString("F2"));
            Console.WriteLine("PREÇO = " + preco.ToString("F2"));


            Console.ReadLine();
        }
    }
}