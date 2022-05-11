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
                    try
                    {


                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);

                        Console.WriteLine("\nTurno: " + partida.turno);
                        Console.Write("Aguardando jogada: " + partida.jogadorAtual);

                        Console.Write("\nOrigem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);


                        bool[,] possicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, possicoesPossiveis);

                        Console.Write("Destino: ");
                        Posicao desitno = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, desitno);

                        partida.realizaJogada(origem, desitno);
                        
                    }
                    catch (TabuleiroExeption ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
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
