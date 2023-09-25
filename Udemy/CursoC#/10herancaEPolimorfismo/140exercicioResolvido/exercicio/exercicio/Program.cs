using exercicio.entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<employee> employees = new List<employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Oursourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employees.Add(new outSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach (employee employee in employees)
            {
                Console.WriteLine($"{employee.name} - $ {employee.payment().ToString("F2")}");
            }
        }
    }
}