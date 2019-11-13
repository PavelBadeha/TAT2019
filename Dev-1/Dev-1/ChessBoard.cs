using System;
using System.Collections.Generic;

namespace Dev_1
{
    class ChessBoard
    {
        private Dictionary<ChessCell, string> CellsColors = new Dictionary<ChessCell, string>();
       
        public ChessBoard()
        {
            ChessBoardInitialize();
        }
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
        public string GetCellColor(ChessFigure cell)
        {
            return CellsColors[cell.ChessBoardPoint];
        }

        public void DisplayOnWhatLineIsTwoFigures(ChessFigure figure1,ChessFigure figure2)
        {
            if(IsTwoFuguresOnOneDioganal(figure1,figure2))
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
        public bool IsTwoFuguresOnOneDioganal(ChessFigure figure1, ChessFigure figure2)
        {
            if ((figure1.ChessBoardPoint.Column - 64 == figure1.ChessBoardPoint.Row
                && figure2.ChessBoardPoint.Column - 64 == figure2.ChessBoardPoint.Row)
                || (figure1.ChessBoardPoint.Column - 64 + figure1.ChessBoardPoint.Row == 9 
                && figure2.ChessBoardPoint.Column - 64 + figure2.ChessBoardPoint.Row == 9 ))
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
