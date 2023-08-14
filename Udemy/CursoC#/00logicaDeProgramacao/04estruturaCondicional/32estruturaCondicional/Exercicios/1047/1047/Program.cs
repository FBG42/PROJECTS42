using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal;

            string[] vet = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            int minutosIniciais = horaInicial * 60 + minutoInicial;
            int minutosFinais = horaFinal * 60 + minutoFinal;

            int duracaoTotalEmMinutos;

            if (minutosIniciais < minutosFinais)
            {
                duracaoTotalEmMinutos = minutosFinais - minutosIniciais;
            }
            else
            {
                duracaoTotalEmMinutos = (24 * 60 - minutosIniciais) + minutosFinais;
            }

            int duracaoHoras = duracaoTotalEmMinutos / 60;
            int duracaoMinutos = duracaoTotalEmMinutos % 60; ;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}