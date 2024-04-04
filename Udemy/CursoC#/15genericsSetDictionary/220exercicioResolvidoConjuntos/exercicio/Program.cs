using System;
using exercicio.entities;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
          HashSet<logRecord> set = new HashSet<logRecord>();

            // System.Console.WriteLine("Enter file full path: ");
            // string path = Console.ReadLine();
            string path = "/home/fbg/Documents/Dev/Study/dev.study/Udemy/CursoC#/15genericsSetDictionary/220exercicioResolvido/exercicio/input.txt";

            try
            {
              using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                  string[] line = sr.ReadLine().Split(' ');
                  string name = line[0];
                  DateTime loggedInstant = DateTime.Parse(line[1]);
                  set.Add(new logRecord{ username = name, isntant = loggedInstant });
                }
                System.Console.WriteLine("Total users: " + set.Count);
              }
            }
            catch (IOException e) {
              System.Console.WriteLine(e.Message);
            }
        }
    }
}