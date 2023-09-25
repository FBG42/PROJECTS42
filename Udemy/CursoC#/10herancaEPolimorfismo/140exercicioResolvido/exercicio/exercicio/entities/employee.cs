using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities
{
    internal class employee
    {
        public string name { get; set; }
        public int hours { get; set; }
        public double valuePerHour { get; set; }
        
        public employee()
        {

        }

        public employee(string name, int hours, double valuePerHour)
        {
            this.name = name;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public virtual double payment()
        {
            return hours * valuePerHour;
        }
    }
}
