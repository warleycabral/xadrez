using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Chess.Enums;

namespace Xadrez.Chess
{
    class Piece
    {
        public Coordinate Coordinate { get; set; }
        public Color Color { get; protected set; }
        public int Moves { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Coordinate coordinate, Color color, Board board)
        {
            Coordinate = coordinate;
            Color = color;
            Board = board;
            Moves = 0;
        }
    }
}
