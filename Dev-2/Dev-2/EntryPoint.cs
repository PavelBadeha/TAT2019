using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_2
{
    /// <summary>
    /// Entry Point
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method
        /// </summary>
        static void Main()
        {
            while(true)
            {
                try
                {
                    StringAnalyzer analyzer = new StringAnalyzer();
                    Console.WriteLine("Max identical digits: " + analyzer.MaxOfIdenticalConsecutiveDigits());
                    Console.WriteLine("Max identical latins: " + analyzer.MaxOfIdenticalConsecutiveLatinSymbols());
                    Console.WriteLine("Max not identical symbols: " + analyzer.MaxOfNotIdenticalConsecutiveSymbols());
                    break;
                }                    
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
