using System;
using tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro P;

            P = new Tabuleiro(3, 4);

            Console.WriteLine(P);
            Console.ReadLine();
        }
    }
}
