using abstratas.entities;

namespace abstratas.entities
{
    class savingsAccount : account
    {
        public double InterestRate { get; set; }

        public savingsAccount()
        {
        }

        public savingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}