using System;

namespace exercicio.services
{
    public interface IonlinePaymentService
    {
        public double paymentFee(double amount);
        public double interest(double amount, int months);
    }
}
