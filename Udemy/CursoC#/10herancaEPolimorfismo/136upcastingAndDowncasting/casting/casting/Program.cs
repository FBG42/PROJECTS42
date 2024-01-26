using casting.entities;
using heranca.entities;
using System;

namespace casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            account acc = new account(1001, "Alex", 0.00);
            bussinesAccount bacc = new bussinesAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            account acc1 = bacc;
            account acc2 = new bussinesAccount(1003, "Bob", 0.0, 200.0);
            account acc3 = new savingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING

            bussinesAccount acc4 = (bussinesAccount) acc2;
            acc4.loan(100.0);

            //bussinesAccount acc5 = (bussinesAccount) acc3;
            if (acc3 is bussinesAccount)
            {
                //bussinesAccount acc5 = (bussinesAccount) acc3;
                bussinesAccount acc5 = acc3 as bussinesAccount;
                acc5.loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is savingsAccount)
            {
                //savingsAccount acc5 = (savingsAccount) acc3;
                savingsAccount acc5 = acc3 as savingsAccount;
                acc5.updateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}