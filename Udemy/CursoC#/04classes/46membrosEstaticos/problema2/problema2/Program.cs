using System;

namespace problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = calculadora.circunferencia(raio);
            double vol = calculadora.volume(raio);

            Console.WriteLine("Circunferência " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + vol.ToString("F2"));
            Console.WriteLine("Valor de PI: " + calculadora.Pi.ToString("F2"));
        }


    }
}