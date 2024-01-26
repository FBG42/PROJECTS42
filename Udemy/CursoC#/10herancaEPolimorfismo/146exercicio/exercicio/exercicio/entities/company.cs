namespace exercicio.entities
{
    internal class company : taxPayer
    {
        public int numberOfEmployees { get; set; }

        public company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            this.numberOfEmployees = numberOfEmployees;
        }

        public override double tax()
        {
            double tax = 0.16;

            if (numberOfEmployees > 16)
            {
                tax = 0.14;
            }

            return anualIncome * tax;
        }
    }
}
