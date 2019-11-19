using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_3
{
    /// <summary>
    /// Entry point class
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 
            while(true)
            {
                try
                {
                    Console.WriteLine("Введите строку");
                    string str = Console.ReadLine();
                    StringTranslator translator = new StringTranslator();
                    Console.WriteLine(translator.Translate(str));
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }    
           
        }
    }
}
