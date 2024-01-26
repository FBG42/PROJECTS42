using exercicio.entities;
using System;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                account ac = new account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                ac.withdraw(amount);

                Console.WriteLine($"New balance: {ac.balance}");
            }
			catch (Exception e)
			{
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}