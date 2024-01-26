using abstratas.entities;

namespace abstratas.entities
{
    class businessAccount : account
    {
        public double LoanLimit { get; set; }

        public businessAccount()
        {
        }

        public businessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}