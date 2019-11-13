using System;

namespace Dev_1
{
    /// <summary>
    /// Class of out of range chess board exception
    /// </summary>
    class OutOfRangeChessBoardException :Exception
    {
        public OutOfRangeChessBoardException(string message):base(message)
        {

        }
    }
}
