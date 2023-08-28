using exercicio1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            retangulo r = new retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.largura = double.Parse(Console.ReadLine());
            r.altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"AREA = {r.area():F2}");
            Console.WriteLine($"PERÍMETRO = {r.perimetro():F2}");
            Console.WriteLine($"DIAGONAL = {r.diagonal():F2}");
        }
    }
}