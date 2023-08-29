using exercicio;
using System;

namespace exercicio // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            room[] r = new room[10];

            for (int i = 0; i < n; i++)
            {
                string name, email;
                int room;

                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                r[room] = new room { tenantName = name, tenantEmail = email, roomNumber = room };
            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < r.Length; i++)
            {
                if (r[i] != null)
                {
                    Console.WriteLine($"{i}: {r[i]}");
                }
            }
        }
    }
}