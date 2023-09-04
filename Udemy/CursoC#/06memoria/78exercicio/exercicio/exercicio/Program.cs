using System;
using System.Collections.Generic;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<employee> employees = new List<employee>();

            for (int i = 1; i <= n; i++)
            {
                employee e = new employee();
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                e.id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                e.name = Console.ReadLine();
                Console.Write("Salary: ");
                e.salary = double.Parse(Console.ReadLine());
                Console.WriteLine();

                employees.Add(e);
            }

            Console.Write("Enter the employee id that wil salary increase : ");
            int idToIncrease = int.Parse(Console.ReadLine());

            employee e1 = employees.Find(employee => employee.id == idToIncrease);

            if (e1 != null)
            {
                Console.Write("Enter the percentage: ");
                double porcentage = double.Parse(Console.ReadLine());
                e1.increaseSalary(porcentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Object employee in employees)
            {
                Console.WriteLine(employee);
            };
        }
    }
}