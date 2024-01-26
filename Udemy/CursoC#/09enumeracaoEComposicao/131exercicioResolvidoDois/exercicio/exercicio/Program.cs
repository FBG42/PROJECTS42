using exercicio.entities;
using System;
using System.Globalization;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            comment c1 = new comment("Have a nice trip");
            comment c2 = new comment("How that's awesome!");

            post p1 = new post(
                 DateTime.ParseExact("21/06/2018 13:05:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture.DateTimeFormat),
                 "Traveling to New Zeland",
                 "I'm going to visist this wonderful country!",
                 12);
            p1.addComment(c1);
            p1.addComment(c2);

            comment c3 = new comment("Good night");
            comment c4 = new comment("May the Force be with you");

            post p2 = new post(
                 DateTime.ParseExact("28/07/2018 23:14:19", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture.DateTimeFormat),
                 "Good night guys",
                 "See you tomorrow",
                 5);
            p2.addComment(c3);
            p2.addComment(c4);

            Console.WriteLine(p1);

            Console.WriteLine(p2);
        }
    }
}