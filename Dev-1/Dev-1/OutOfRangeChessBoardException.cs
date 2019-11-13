using System;

namespace Dev_1
{
    class OutOfRangeChessBoardException:Exception
    {
        public OutOfRangeChessBoardException(string message):base(message)
        {

        }
    }
}
