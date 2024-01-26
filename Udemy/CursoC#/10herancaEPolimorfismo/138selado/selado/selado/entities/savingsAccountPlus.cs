using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selado.entities
{
    class savingsAccountPlus : savingsAccount
    {
        public override void withdraw(double amount)
        {
            base.withdraw(amount);
        }
    }
}
