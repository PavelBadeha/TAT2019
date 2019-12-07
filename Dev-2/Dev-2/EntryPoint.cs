using System;

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
        static void Main(string[] args)
        {
                try
                {
                var analyzer = new Dev_2.StringAnalyzer();
                int expected = 3;
                string actual = "14912ZzZZZ";
                Console.WriteLine( analyzer.MaxOfIdenticalConsecutiveLatinSymbols(actual));
                //string str = args[0];
                //StringAnalyzer analyzer = new StringAnalyzer();
                //Console.WriteLine("Max identical digits: " + analyzer.MaxOfIdenticalConsecutiveDigits(str));
                //Console.WriteLine("Max identical latins: " + analyzer.MaxOfIdenticalConsecutiveLatinSymbols(str));
                //Console.WriteLine("Max not identical symbols: " + analyzer.MaxOfNotIdenticalConsecutiveSymbols(str));
            }                    
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
        }
    }
}
