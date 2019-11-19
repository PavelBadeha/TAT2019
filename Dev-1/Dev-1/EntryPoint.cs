using System;

namespace Dev_1
{
    /// <summary>
    /// Class of entry point
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method 
        /// </summary>
        static void Main()
        {
            try
            {
                ChessFigure figure1 = new ChessFigure('a', 1);
                ChessFigure figure2 = new ChessFigure('g', 3);
                ChessBoard board = new ChessBoard();

                Console.WriteLine(board.GetCellColor(figure1));
                Console.WriteLine(board.GetCellColor(figure2));
                board.DisplayWhichLineTwoFiguresAreOn(figure1, figure2);              
            }
            catch(OutOfRangeChessBoardException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
