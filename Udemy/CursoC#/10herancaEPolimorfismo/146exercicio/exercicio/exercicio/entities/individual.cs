namespace exercicio.entities
{
    internal class individual : taxPayer
    {
        public double healthExpenditures { get; set; }

        public individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            this.healthExpenditures = healthExpenditures;
        }

        public override double tax()
        {
            double tax = 0;

            if (anualIncome < 20000.00)
            {
                tax = 0.15;
            }
            else if (anualIncome > 20000.00)
            {
                tax = 0.25;
            }


            return (anualIncome * tax) - (healthExpenditures * 0.50);
        }
    }
}
