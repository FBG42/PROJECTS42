using selado.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selado.entities
{
    internal class savingsAccount : account
    {
        public double interestRate { get; set; }

        public savingsAccount()
        {

        }

        public savingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            this.interestRate = interestRate;
        }

        public void updateBalance()
        {
            balance += balance * interestRate;
        }

        public sealed override void withdraw(double amount)
        {
            base.withdraw(amount);
            balance -= 2.00;
        }
    }
}
