using System;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "/home/fbg/Documents/Dev/Study/dev.study/Udemy/CursoC#/15genericsSetDictionary/223exercicioDictonary/exercicio/input.txt";

            Dictionary<string, int> totalVotes = new Dictionary<string, int>();

            try
            {
              using (StreamReader file = File.OpenText(path))
              {
                while (!file.EndOfStream) {
                  string[] line = file.ReadLine().Split(',');

                  if (totalVotes.ContainsKey(line[0]))
                  {
                    totalVotes[line[0]] += int.Parse(line[1]);
                  }
                  else
                  {
                    totalVotes[line[0]] = int.Parse(line[1]);
                  }
                }

              }
            }
            catch (IOException e) {
              System.Console.WriteLine(e.Message);
            }

            foreach (KeyValuePair<string, int> candidate in totalVotes)
            {
              System.Console.WriteLine($"{candidate.Key}: {candidate.Value}");
            }
        }
    }
}