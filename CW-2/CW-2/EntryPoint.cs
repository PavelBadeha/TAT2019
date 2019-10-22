using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System;

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
            //string json = JsonConvert.SerializeObject(creator.Universities);
            //

            XmlDBProvider provider = new XmlDBProvider();
            JsonProvider jsonProvider = new JsonProvider();
            provider.Initialize();
            jsonProvider.Initialize();

            UniversityCreator creator = new UniversityCreator(provider);
            creator.CreateUniversities();
                        
            Console.WriteLine(provider.GetParkingsByUniversityName("BSU").Count);
            Console.WriteLine(jsonProvider.GetParkingsByUniversityName("BSU").Count);
        }
    }
}
                                                                                                                                                                       