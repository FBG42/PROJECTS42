using exercicio.entities.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities
{
    internal class account
    {
        public int number { get; set; }
        public string holder { get; set; }
        public double balance { get; set; }
        public double withdrawLimit { get; set; }

        public account(int number, string holder, double balance, double withdrawLimit)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
            this.withdrawLimit = withdrawLimit;
        }

        public void deposit(double amount)
        {
            this.balance += amount;
        }

        public void withdraw(double amount)
        {
            if (amount > withdrawLimit)
            {
                throw new withdrawException("The amount exceeds withdraw limit");
            }

            if (amount > balance)
            {
                throw new withdrawException("Not enough balance");
            }
        }
    }
}
