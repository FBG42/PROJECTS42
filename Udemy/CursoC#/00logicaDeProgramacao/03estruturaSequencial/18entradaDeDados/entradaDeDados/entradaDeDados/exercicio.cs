using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program2
    {
        static void Exercicio(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quantQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);


            Console.WriteLine(nome);
            Console.WriteLine(quantQuartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}