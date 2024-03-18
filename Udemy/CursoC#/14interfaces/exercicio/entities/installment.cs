using System;
using System.Globalization;

namespace exercicio.entities
{
    public class installment
    {
        public DateTime date { get; set; }
        public double amount { get; set; }

        public override string ToString()
        {
            return $"{date.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"))} - {amount}";
        }
    }
}
