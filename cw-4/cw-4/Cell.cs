using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_4
{
    class Cell
    {
       public char Column { get; private set; }
       public int Row { get; private set; }

       private List<char> listOfColumns = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
       public Cell()
       {
            Initialize();
       }
       private void Initialize()
       {
            Console.WriteLine("Print column:");
            Column = Console.ReadLine().ToCharArray()[0];
            Console.WriteLine("Print row");
            Row = int.Parse(Console.ReadLine());
            if (!listOfColumns.Any(x => x.Equals(Column)) || Row > 8 || Row < 0)
            {
                throw new OutOfRangeChessBoardException("Cell is out of chess board range");
            }
            Console.WriteLine("Good choice");
       }
    }
}
