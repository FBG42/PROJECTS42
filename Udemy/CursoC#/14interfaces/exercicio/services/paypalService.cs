using System;

namespace exercicio.services
{
    public class paypalService : IonlinePaymentService
    {
        public double paymentFee(double amount) {
            return amount + (amount * 0.2);
        }

        public double interest(double amount, int month) {
            double onePorcentage = amount * 0.1;
            double quota = onePorcentage * month;
            return amount + quota;
        }
    }
}
