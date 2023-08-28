namespace exercicio1
{
    internal class ConversorDeMoeda
    {
        public static double iOF = 6.0;

        public static double dolarParaReal(double cotacao, double quantia)
        {
            double result, taxa;

            result = cotacao * quantia;

            taxa = result * iOF / 100;

            result += taxa;

            return result;
        }
    }
}
