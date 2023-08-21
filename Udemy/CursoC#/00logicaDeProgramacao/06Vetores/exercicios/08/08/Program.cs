using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, numeroDeHomens;
            double menorAltura, maiorAltura, mediaDeAlturaMulheres;
            double[] altura;
            char[] genero;
            string[] vet;


            N = int.Parse(Console.ReadLine());

            altura = new double[N];
            genero = new char[N];

            for (int i  = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');

                altura[i] = double.Parse(vet[0]);
                genero[i] = char.Parse(vet[1]);
            }

            menorAltura = 0;
            maiorAltura = 0;
            mediaDeAlturaMulheres = 0;
            numeroDeHomens = 0;
            for (int i = 0; i < N; i++)
            {
                if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }

                if (genero[i] == 'M')
                {
                    numeroDeHomens++;
                }
                else
                {
                    mediaDeAlturaMulheres += altura[i];
                }

            }

            menorAltura = maiorAltura;
            for (int i = 0; i < N; i++)
            {
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
            }

            mediaDeAlturaMulheres = mediaDeAlturaMulheres / (altura.Length - numeroDeHomens);

            Console.WriteLine($"Menor altura = {menorAltura:F2}");
            Console.WriteLine($"Maior altura = {maiorAltura:F2}");
            Console.WriteLine($"Media das alturas das mulheres = {mediaDeAlturaMulheres:F2}");
            Console.WriteLine($"Numero de homens = {numeroDeHomens}");
        }
    }
}