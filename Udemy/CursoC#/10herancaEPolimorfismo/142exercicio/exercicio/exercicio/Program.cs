using exercicio.entities;
using System;
using System.Globalization;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<product> products = new List<product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeOfProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (typeOfProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new importedProduct(name, price, customsFee));
                }
                else if (typeOfProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", new CultureInfo("pt-BR"));
                    products.Add(new usedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}