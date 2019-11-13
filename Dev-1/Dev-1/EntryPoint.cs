using System;

namespace Dev_1
{
    class EntryPoint
    {
        static void Main()
        {
            try
            {
                ChessFigure figure1 = new ChessFigure('d', 5);
                ChessFigure figure2 = new ChessFigure('f', 3);
                ChessBoard board = new ChessBoard();

                Console.WriteLine(board.GetCellColor(figure1));
                Console.WriteLine(board.GetCellColor(figure2));
                board.DisplayOnWhatLineIsTwoFigures(figure1, figure2);
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
