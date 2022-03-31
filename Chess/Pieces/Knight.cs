using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Chess.Enums;

namespace Xadrez.Chess.Pieces
{
    class Knight : Piece
    {
        public Knight(Color color, Board board) : base(color, board)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
