using System;

namespace CW_2
{
    /// <summary>
    ///Main class of the program. 
    /// </summary>
    class EntryPoint
    {
        /// summary>
        /// The entry point.
        /// </summary>
        static void Main()
        {
            XmlDBProvider xmlProvider = new XmlDBProvider();
            JsonProvider jsonProvider = new JsonProvider();
            xmlProvider.Initialize();
            jsonProvider.Initialize();

            UniversityCreator creator = new UniversityCreator(xmlProvider);
            creator.CreateUniversities();
            Console.WriteLine("XML\n" + creator.Universities[0]);

            creator = new UniversityCreator(jsonProvider);
            creator.CreateUniversities();
            Console.WriteLine("JSON\n" + creator.Universities[0]);
        }    
    } 
}
                                                                                                                                                                       