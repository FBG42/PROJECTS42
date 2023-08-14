using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double total;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)
            {
                total = quantidade * 4.0;

            } else if (codigo == 2)
            {
                total = quantidade * 4.5;
            } else if (codigo == 3)
            {
                total = quantidade * 5.0;
            } else if (codigo == 4)
            {
                 total = quantidade * 2.0;
            } else
            {
                total = quantidade * 1.5;
            }
  
            
            Console.WriteLine("Total: R$ " + total.ToString("F2"));

        }
    }
}