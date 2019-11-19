using System;
using System.Collections.Generic;
using System.Linq;

namespace Dev_1
{
    /// <summary>
    /// Class of chess figure
    /// </summary>
    class ChessFigure
    {
        /// <summary>
        /// List of columns
        /// </summary>
        private List<char> _listOfColumns = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

        /// <summary>
        /// Point on chess board
        /// </summary>
        public ChessCell ChessBoardPoint { get; private set; }
        
        /// <summary>
        /// Class constructor without params
        /// </summary>
        public ChessFigure()
        {
            Console.WriteLine("Print column:");
            char column = Console.ReadLine().ToCharArray()[0];

            Console.WriteLine("Print row");
            int row = int.Parse(Console.ReadLine());

            ValidationCheck(column, row);
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="column">Char of column</param>
        /// <param name="row">Number of row</param>
        public ChessFigure(char column,int row)
        {
            ValidationCheck(column, row);
        }

        /// <summary>
        /// Method that check for validation
        /// </summary>
        /// <param name="column">Char of column</param>
        /// <param name="row">Number of row</param>
        private void ValidationCheck(char column,int row)
        {
            if ((!_listOfColumns.Any(x => x.Equals(column)) && !_listOfColumns.Any(x => x.Equals((char)(column - 32))))
                                                            || row > 8 || row < 1)
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
