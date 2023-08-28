namespace exercicio
{
    internal class conta
    {
        public double saldoDaConta { get; private set; }
        public int numeroDaConta { get; private set; }
        public string nomeDoTitular { get; set; }


        public conta(int _numeroDaConta, string _nomeDoTitular)
        {
            numeroDaConta = _numeroDaConta;
            nomeDoTitular = _nomeDoTitular;
        }

        public conta(int _numeroDaConta, string _nomeDoTitular, double depositoInicial) : this(_numeroDaConta, _nomeDoTitular)
        {
            depositoEmConta(depositoInicial);
        }

        public double depositoEmConta(double quantiaHaDepositar)
        {
            return saldoDaConta += quantiaHaDepositar;
        }

        public double saqueEmConta(double quantiaHaSacar)
        {
            saldoDaConta -= quantiaHaSacar;
            saldoDaConta -= 5;
            return saldoDaConta;
        }

        public override string ToString()
        {
            return $"Conta {numeroDaConta}, Titular: {nomeDoTitular}, Saldo: $ {saldoDaConta:F2}";
        }
    }
}
