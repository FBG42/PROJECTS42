using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca.entities
{
    internal class account
    {
        public int number { get; private set; }
        public string holder { get; private set; }
        public double balance { get; protected set; }

        public account()
        {

        }

        public account(int number, string holder, double balance)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
        }

        public virtual void withdraw(double amount)
        {
            balance -= amount + 5.00;
        }

        public void deposit(double amount)
        {
            balance += amount;
        }
    }
}
