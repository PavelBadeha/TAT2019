using System;

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
            while (true)
            {
                try
                {
                    StringTranslitor translator = new StringTranslitor();
                    Console.WriteLine(translator.Translite(Console.ReadLine()));
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
