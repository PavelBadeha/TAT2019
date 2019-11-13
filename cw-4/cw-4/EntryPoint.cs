using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
           Cell cell;

           while(true)
           {
                try
                {
                    cell = new Cell();
                    break;
                }
                catch(OutOfRangeChessBoardException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
           }
        }
    }
}
