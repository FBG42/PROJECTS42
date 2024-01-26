using System;

namespace exercicio.entities
{
    internal class hourContract
    {
        public DateTime date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

        public hourContract()
        {

        }
        public hourContract(DateTime date, double valuePerHour, int hours)
        {
            this.date = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }

        public double totalValue()
        {
            return hours * valuePerHour;
        }
    }
}
