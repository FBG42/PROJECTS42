using System;
using System.Collections.Generic;
using abstratas.entities;


namespace abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<account> list = new List<account>();

            list.Add(new savingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new businessAccount(1002, "Maria", 500.0, 400.00));
            list.Add(new savingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new businessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2"));

            foreach ( account account in list)
            {
                account.Withdraw(10.0);
            }

            foreach (account acc in list)
            {
                Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance:F2}");
            }
        }
    }
}