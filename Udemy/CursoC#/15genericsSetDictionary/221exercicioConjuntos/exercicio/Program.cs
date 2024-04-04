using System;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
          char[] coursesLetter = {'A', 'B', 'C'};

          HashSet<student> set = new HashSet<student>();

          for (int i = 0; i < coursesLetter.Length; i++)
          {
            System.Console.Write($"How many students for course {coursesLetter[i]}: ");
            int n = int.Parse(Console.ReadLine());

            for (int y = 0; y < n; y++)
            {
              int idInserted = int.Parse(Console.ReadLine());
              set.Add(new student { id = idInserted });
            }
          }

          System.Console.WriteLine($"Total students: {set.Count}");
        }
    }
}