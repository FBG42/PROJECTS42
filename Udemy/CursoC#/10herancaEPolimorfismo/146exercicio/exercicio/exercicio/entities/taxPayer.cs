namespace exercicio.entities
{
    abstract internal class taxPayer
    {
        public string name { get; set; }
        public double anualIncome { get; set; }

        public taxPayer(string name, double anualIncome)
        {
            this.name = name;
            this.anualIncome = anualIncome;
        }

        public abstract double tax();
    }
}
