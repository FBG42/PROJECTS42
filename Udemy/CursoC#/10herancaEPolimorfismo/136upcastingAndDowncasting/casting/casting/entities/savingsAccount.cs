using heranca.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casting.entities
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
    }
}
