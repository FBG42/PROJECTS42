using selado.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selado.entities
{
    internal class businessAccount : account
    {
        public double loanLimit { get; set; }

        public businessAccount()
        {

        }

        public businessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {

            this.loanLimit = loanLimit;
        }

        public void loan(double amount)
        {
            if (amount <= loanLimit)
            {
                balance += amount;
            }
        }
    }
}
