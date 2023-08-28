namespace problema2
{
    internal class calculadora
    {
        public static double Pi = 3.14;

        public static double circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public static double volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
    }
}
