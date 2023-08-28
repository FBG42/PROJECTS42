namespace exercicio2
{
    internal class funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double salarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void aumentarSalario(double porcentagem)
        {
            double haAumentar = porcentagem * salarioBruto / 100;
            salarioBruto += haAumentar;
        }


        public override string ToString()
        {
            return $"{nome}, $ {salarioLiquido():F2}";
        }
    }
}
