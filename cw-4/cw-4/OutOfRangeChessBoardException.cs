using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_4
{
    class OutOfRangeChessBoardException:Exception
    {
       public OutOfRangeChessBoardException(string message):base(message) { }
    }
}
