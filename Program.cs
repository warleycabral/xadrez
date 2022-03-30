using System;
using Xadrez;
using Xadrez.Chess;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Board tabuleiro = new Board(8,8);
            Screen.PrintBoard(tabuleiro);
            
        }
    }
}
