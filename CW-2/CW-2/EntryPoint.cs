using System;
using System.Xml;
using System.Xml.Linq;
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
            provider.Initialization();
            UniversityCreator creator= new UniversityCreator(provider);
            creator.CreateUniversities();
           foreach(var univer in creator.GetUniversities())
            {
                Console.WriteLine(univer);
            }

        }
    }
}
                                                                                                                                                                       