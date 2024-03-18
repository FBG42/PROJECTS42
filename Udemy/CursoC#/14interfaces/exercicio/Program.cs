
using System.Globalization;
using exercicio.entities;
using exercicio.services;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            contract _contract = new contract(contractNumber, contractDate, contractValue);

            contractService _contractService = new contractService(new paypalService());

            _contractService.processContract(_contract, installments);

            Console.WriteLine("Installments:");
            foreach (var installment in _contract.installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
