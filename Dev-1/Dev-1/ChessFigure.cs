using System;
using System.Collections.Generic;
using System.Linq;

namespace Dev_1
{
    class ChessFigure
    {
        private List<char> listOfColumns = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        public ChessCell ChessBoardPoint { get; private set; }
        
        public ChessFigure()
        {
            Console.WriteLine("Print column:");
            char column = Console.ReadLine().ToCharArray()[0];

            Console.WriteLine("Print row");
            int row = int.Parse(Console.ReadLine());

            ValidationCheck(column, row);
        }
        public ChessFigure(char column,int row)
        {
            ValidationCheck(column, row);
        }
        private void ValidationCheck(char column,int row)
        {
            if ((!listOfColumns.Any(x => x.Equals(column)) && !listOfColumns.Any(x => x.Equals((char)(column - 32))))
                                                            || row > 8 || row < 0)
            {
                throw new OutOfRangeChessBoardException("Cell is out of chess board range");
            }
            else
            {
                ChessBoardPoint = new ChessCell(column, row); 
            }
        }
    }
}
