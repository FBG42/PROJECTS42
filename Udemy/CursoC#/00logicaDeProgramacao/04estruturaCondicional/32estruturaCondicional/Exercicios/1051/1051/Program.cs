using System;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());

            double impostoDeRenda = 0.0;

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000.00)
            {
                impostoDeRenda = (salario - 2000.00) * 0.08;
                Console.WriteLine($"R$ {impostoDeRenda:F2}");
            }
            else if (salario <= 4500.00)
            {
                impostoDeRenda = 1000.00 * 0.08 + (salario - 3000.00) * 0.18;
                Console.WriteLine($"R$ {impostoDeRenda:F2}");
            }
            else
            {
                impostoDeRenda = 1000.00 * 0.08 + 1500.00 * 0.18 + (salario - 4500.00) * 0.28;
                Console.WriteLine($"R$ {impostoDeRenda:F2}");
            }
        }
    }
}
