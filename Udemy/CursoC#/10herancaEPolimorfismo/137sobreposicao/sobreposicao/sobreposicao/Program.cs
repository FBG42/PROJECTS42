using casting.entities;
using heranca.entities;
using System;

namespace sobreposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            account acc1 = new account(1001, "Alex", 500.0);
            account acc2 = new savingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.withdraw(10.0);
            acc2.withdraw(10.0);

            Console.WriteLine(acc1.balance);
            Console.WriteLine(acc2.balance);
        }
    }
}