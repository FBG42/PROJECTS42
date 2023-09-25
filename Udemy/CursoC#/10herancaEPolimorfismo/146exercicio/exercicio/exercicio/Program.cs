using exercicio.entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<taxPayer> taxes = new List<taxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxes.Add(new individual(name, anualIncome, healthExpenditures));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxes.Add(new company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double sum = 0;
            foreach (taxPayer taxPayer in taxes)
            {
                Console.WriteLine($"{taxPayer.name}: $ {taxPayer.tax().ToString("F2")}");

                sum += taxPayer.tax();
            }

            Console.WriteLine($"TOTAL TAXES: $ {sum:F2}");
        }
    }
}