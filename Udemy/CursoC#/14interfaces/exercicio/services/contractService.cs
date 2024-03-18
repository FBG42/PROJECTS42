using exercicio.entities;

namespace exercicio.services
{
    public class contractService
    {
        IonlinePaymentService _onlinePaymentService;

        public contractService( IonlinePaymentService paymentService) {
            _onlinePaymentService = paymentService;
        }

        public void processContract(contract contract, int months)
        {
            contract.installments = new List<installment>();


            for (int i = 1; i < months + 1; i++)
            {
                double amount = contract.totalValue / months;
                amount = _onlinePaymentService.interest(amount, i);
                amount =_onlinePaymentService.paymentFee(amount);

                installment installment = new installment
                {
                    amount = amount,
                    date = contract.date.AddMonths(i)
                };

                contract.installments.Add(installment);
            }
        }
    }
}
