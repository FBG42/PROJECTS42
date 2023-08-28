namespace exercicio3
{
    internal class aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double notaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public void aprovadoOuReprovado()
        {
            if (notaFinal() >= 60.00)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                double restante = 60.00 - notaFinal();
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {restante:F2} PONTOS");
            }
        }

    }
}
