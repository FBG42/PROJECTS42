using criandoExcecoes.entities;
using System;
using System.Globalization;

namespace criandoExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", new CultureInfo("pt-BR"));
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", new CultureInfo("pt-BR"));

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                reservation reservation = new reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", new CultureInfo("pt-BR"));
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", new CultureInfo("pt-BR"));

                DateTime now = DateTime.Now;

                if (checkIn <= now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future date");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    reservation.updateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}