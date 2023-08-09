using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet1, vet2;
            string entrada1, entrada2;
            int codigo1, codigo2, numeroDePecas1, numeroDePecas2;
            double valorUnitario1, valorUnitario2, total;


            entrada1 = Console.ReadLine();
            entrada2 = Console.ReadLine();


            vet1 = entrada1.Split(' ');

            codigo1 = int.Parse(vet1[0]);
            numeroDePecas1 = int.Parse(vet1[1]);
            valorUnitario1 = double.Parse(vet1[2]);

            vet2 = entrada2.Split(' ');

            codigo2 = int.Parse(vet2[0]);
            numeroDePecas2 = int.Parse(vet2[1]);
            valorUnitario2 = double.Parse(vet2[2]);


            total = (numeroDePecas1 * valorUnitario1) + (numeroDePecas2 * valorUnitario2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}