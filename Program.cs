using System;
using Xadrez;
using Xadrez.Chess;
using Xadrez.Chess.Enums;
using Xadrez.Chess.Pieces;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8,8);

            board.PutPiece(new Knight(Color.Black, board), new Coordinate(0, 0));
            board.PutPiece(new Knight(Color.Black, board), new Coordinate(1, 3));
            board.PutPiece(new King(Color.Black, board), new Coordinate(2, 4));
            
            Screen.PrintBoard(board);
        }
    }
}
