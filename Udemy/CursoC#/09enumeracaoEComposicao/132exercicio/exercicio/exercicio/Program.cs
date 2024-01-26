using exercicio.entities;
using exercicio.entities.enums;
using System;
using System.Globalization;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture.DateTimeFormat);

            client client = new client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status (pendingPayment/processing/shipped/delivered): ");
            orderStatus status = Enum.Parse<orderStatus>(Console.ReadLine());

            order order = new order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int totalOfItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= totalOfItems; i++ )
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                product product = new product(productName, productPrice);
                orderItem orderItem = new orderItem(quantity, product.price, product);
                order.addItem(orderItem);
            }

            Console.WriteLine(order);
        }
    }
}