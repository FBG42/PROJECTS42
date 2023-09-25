using metodos.entities;
using metodos.entities.enums;
using System;

namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<shape> list = new List<shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (black/blue/red): ");
                color color = Enum.Parse<color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (shape shape in list)
            {
                Console.WriteLine(shape.area().ToString("F2"));
            }
        }
    }
}