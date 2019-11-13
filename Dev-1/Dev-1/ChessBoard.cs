using System;
using System.Collections.Generic;

namespace Dev_1
{
    /// <summary>
    /// Class of chess board
    /// </summary>
    class ChessBoard
    {
        /// <summary>
        /// Dictionary of cell->color
        /// </summary>
        private Dictionary<ChessCell, string> CellsColors = new Dictionary<ChessCell, string>();
       
        /// <summary>
        /// Class constructor without params
        /// </summary>
        public ChessBoard()
        {
            ChessBoardInitialize();
        }

        /// <summary>
        /// Method of chess board initialization(initialize dictionay CellsColor)
        /// </summary>
        private void ChessBoardInitialize()
        {
            ChessCell buffPoint;
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    buffPoint = new ChessCell((char)(i + 64), j);
                    if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
                    {
                        CellsColors.Add(buffPoint, "Cell is black");
                    }
                    else
                    {
                        CellsColors.Add(buffPoint, "Cell is white");
                    }
                }
            }
        }

        /// <summary>
        /// Method that return color of cell
        /// </summary>
        /// <param name="figure">Chess figure for which need to return color</param>
        /// <returns></returns>
        public string GetCellColor(ChessFigure figure)
        {
            return CellsColors[figure.ChessBoardPoint];
        }

        /// <summary>
        /// Method shows which line two figures are on
        /// </summary>
        /// <param name="figure1">First figure</param>
        /// <param name="figure2">Second figure</param>
        public void DisplayWhichLineTwoFiguresAreOn(ChessFigure figure1,ChessFigure figure2)
        {
            if(IsTwoFuguresOnOneDiagonal(figure1,figure2))
            {
                Console.WriteLine("On one dioganal");
            }
            else if(IsTwoFuguresOnOneHorizontal(figure1,figure2))
            {
                Console.WriteLine("On one horizontal");
            }
            else if(IsTwoFuguresOnOneVertical(figure1,figure2))
            {
                Console.WriteLine("On one vertical");
            }
            else
            {
                Console.WriteLine("No one");
            }
        }

        /// <summary>
        /// Method shows whether the figures are on the same vertical
        /// </summary>
        /// <param name="figure1">First figure</param>
        /// <param name="figure2">Second figure</param>
        /// <returns></returns>
        public bool IsTwoFuguresOnOneVertical(ChessFigure figure1,ChessFigure figure2)
        {
            if(figure1.ChessBoardPoint.Column==figure2.ChessBoardPoint.Column)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method shows whether the figures are on the same horizontal
        /// </summary>
        /// <param name="figure1">First figure</param>
        /// <param name="figure2">Second figure</param>
        /// <returns></returns>
        public bool IsTwoFuguresOnOneHorizontal(ChessFigure figure1, ChessFigure figure2)
        {
            if (figure1.ChessBoardPoint.Row == figure2.ChessBoardPoint.Row)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method shows whether the figures are on the same diagonal
        /// </summary>
        /// <param name="figure1">First figure</param>
        /// <param name="figure2">Second figure</param>
        /// <returns></returns>
        public bool IsTwoFuguresOnOneDiagonal(ChessFigure figure1, ChessFigure figure2)
        {
            int f1Row = figure1.ChessBoardPoint.Row;
            int f2Row = figure2.ChessBoardPoint.Row;
            int f1Col = figure1.ChessBoardPoint.Column - 64;
            int f2Col = figure2.ChessBoardPoint.Column - 64;

            if (GetCellColor(figure1) == GetCellColor(figure2) && (Math.Abs(f1Col + f1Row - (f2Col + f2Row)) 
                == Math.Abs(f1Row- f2Row) + Math.Abs(f1Col - f2Col) || f1Col + f1Row == f2Col + f2Row))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
