using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_1
{
    struct ChessCell
    {
        public char Column { get; }
        public int Row { get; }
        public ChessCell(char column,int row)
        {
            if (column > 96) 
            {
                Column = (char)(column - 32);
            }
            else
            {
                Column = column;
            }
            Row = row;
        }
    }
}
