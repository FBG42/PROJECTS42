using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, lucroAbaixoDeDez, lucroEntreDezVinte, lucroAcimaDeVinte;
            double totalDaCompra, totalDaVenda, lucroTotal, porcentagemDeLucro;
            string[] produtos;
            double[] precoDeCompra;
            double[] precoDeVenda;
            string[] vet;

            N = int.Parse(Console.ReadLine());

            produtos = new string[N];
            precoDeCompra = new double[N];
            precoDeVenda = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');

                produtos[i] = vet[0];
                precoDeCompra[i] = double.Parse(vet[1]);
                precoDeVenda[i] = double.Parse(vet[2]);
            }

            lucroAbaixoDeDez = 0;
            lucroEntreDezVinte = 0;
            lucroAcimaDeVinte = 0;
            totalDaCompra = 0;
            totalDaVenda = 0;
            lucroTotal = 0;

            for (int i = 0; i < N;i++)
            {
                porcentagemDeLucro = (precoDeVenda[i] - precoDeCompra[i]) / precoDeVenda[i] * 100;
                porcentagemDeLucro = Math.Round(porcentagemDeLucro, 1);
                if (porcentagemDeLucro < 10)
                {
                    lucroAbaixoDeDez++;
                }

                if (porcentagemDeLucro >= 10 && porcentagemDeLucro < 20)
                {
                    lucroEntreDezVinte++;
                }

                if (porcentagemDeLucro >= 20)
                {
                    lucroAcimaDeVinte++;
                }

                totalDaCompra += precoDeCompra[i];
                totalDaVenda += precoDeVenda[i];

            }

            lucroTotal = totalDaVenda - totalDaCompra;

            Console.WriteLine($"Lucro abaixo de 10%: {lucroAbaixoDeDez}");
            Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntreDezVinte}");
            Console.WriteLine($"Lucro acima de 20%: {lucroAcimaDeVinte}");
            Console.WriteLine($"Valor total da compra: {totalDaCompra:F2}");
            Console.WriteLine($"Valor total da venda: {totalDaVenda:F2}");
            Console.WriteLine($"Lucro total: {lucroTotal:F2}");
        }
    }
}