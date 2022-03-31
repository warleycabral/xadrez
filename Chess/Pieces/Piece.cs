using Xadrez.Chess.Enums;

namespace Xadrez.Chess.Pieces
{
    class Piece
    {
        public Coordinate Coordinate { get; set; }
        public Color Color { get; protected set; }
        public int Moves { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Color color, Board board)
        {
            Coordinate = null;
            Color = color;
            Board = board;
            Moves = 0;
        }
    }
}
