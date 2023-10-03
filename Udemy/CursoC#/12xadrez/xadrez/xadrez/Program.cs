using tabuleiro;
using xadrez;

namespace xadrez_console
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                PartidaDeXadrez partida = new PartidaDeXadrez();


               

                Tela.imprimirTabuleiro(partida.tab);

            }
			catch (TabuleiroExpection e)
			{
                Console.WriteLine(e.Message);
            }
        }
    }
}