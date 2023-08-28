using exercicio;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int nmrDaConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titularDaConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char haveraDeposito = char.Parse(Console.ReadLine());

            conta c;

            if (haveraDeposito == 's' || haveraDeposito == 'S')
            {
                Console.Write("Entre o valor de depósito inical: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                c = new conta(nmrDaConta, titularDaConta, depositoInicial);
            }
            else
            {
                c = new conta(nmrDaConta, titularDaConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);


            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            c.depositoEmConta(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            c.saqueEmConta(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
        }
    }
}