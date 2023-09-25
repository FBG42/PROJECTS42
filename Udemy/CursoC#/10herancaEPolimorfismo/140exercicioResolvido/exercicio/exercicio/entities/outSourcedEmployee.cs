using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities
{
    internal class outSourcedEmployee : employee
    {
        public double addtionalCharge { get; set; }

        public outSourcedEmployee()
        {

        }

        public outSourcedEmployee(string name, int hours, double valuePerHour, double addtionalCharge) : base(name, hours, valuePerHour)
        {
            this.addtionalCharge = addtionalCharge;
        }

        public override double payment()
        {
            return base.payment() + 1.1 * addtionalCharge;
        }
    }
}
