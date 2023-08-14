using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int N, quociente, resto, ano, mes, dias;

            N = int.Parse(Console.ReadLine());

            resto = N;
            ano = 365;
            quociente = resto / ano;
            Console.WriteLine(quociente + " ano(s)");
            resto = resto % ano;

            mes = 30;
            quociente = resto / mes;
            Console.WriteLine(quociente + " mes(es)");
            resto = resto % mes;

            Console.WriteLine(resto + " dia(s)");
        }
    }
}