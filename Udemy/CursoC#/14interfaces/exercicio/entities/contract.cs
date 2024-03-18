using System;

namespace exercicio.entities
{
    public class contract
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double totalValue { get; set; }
        public List<installment> installments { get; set; }

        public contract(int number, DateTime date, double totalValue) {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
        }


    }
}
