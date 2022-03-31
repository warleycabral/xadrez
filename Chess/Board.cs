using Xadrez.Chess.Pieces;

namespace Xadrez.Chess
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] pieces;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            pieces = new Piece[lines, columns];
        }

        public Piece Piece(int line, int column)
        {
            return pieces[line, column];
        }
        public void PutPiece(Piece p, Coordinate coordinate)
        {
            pieces[coordinate.Line, coordinate.Column] = p;
            p.Coordinate = coordinate;
        }
    }
}
