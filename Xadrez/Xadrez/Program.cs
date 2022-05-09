using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
             

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    

                    bool[,] possicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, possicoesPossiveis);

                    Console.Write("Destino: ");
                    Posicao desitno = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, desitno);
                }
            }
            catch (TabuleiroExeption e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            Console.ReadLine();
        }
    }
}
