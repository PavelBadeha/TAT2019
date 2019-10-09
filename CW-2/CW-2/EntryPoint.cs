using System;
using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    ///Main class of the program. 
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point.
        /// </summary>
        static void Main()
        {
            XmlDBProvider provider = new XmlDBProvider();
            UniversityCreator creator= new UniversityCreator(provider);
            Console.WriteLine(creator.GetUniversityById(0));
        }
    }
}
                                                                                                                                                                       