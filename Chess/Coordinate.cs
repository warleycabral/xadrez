using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Chess
{
    class Coordinate
    {
        public int Line { get; set; }
        public int Column { get; set; }

        public Coordinate(int line, int column)
        {
            Line = line;
            Column = column;
        }
        public override string ToString()
        {
            return Line 
                + ", " 
                + Column;
        }
    }
}
