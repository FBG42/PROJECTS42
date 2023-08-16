using System;
using System.Linq.Expressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool, gasolina, diesel, produtoEscolhido;

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            produtoEscolhido = int.Parse(Console.ReadLine());

            while (produtoEscolhido != 4)
            {
                switch (produtoEscolhido)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    default:
                        break;
                }

                produtoEscolhido = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " +  diesel);

        }
    }
}