using enumerations.entities;
using enumerations.entities.enums;
using System;

namespace enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            order order = new order
            {
                id = 1080,
                moment = DateTime.Now,
                status = orderStatus.pendingPayment
            };

            Console.WriteLine(order);

            string txt = orderStatus.pendingPayment.ToString();

            orderStatus os = Enum.Parse<orderStatus>("delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}