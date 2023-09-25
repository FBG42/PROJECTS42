using heranca.entities;
using System;

namespace heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bussinesAccount account = new bussinesAccount(8010, "bob brown", 100.0, 500.0);

            Console.WriteLine(account.balance);

            //account.balance = 200.0;
        }
    }
}