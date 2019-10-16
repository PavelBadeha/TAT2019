using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace CW_2
{
    class JsonProvider
    {

        public JsonProvider()
        {
            List<University> universities = new List<University>();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"A:\repos\CW-2\CW-2\JsonFiles\Univer.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer,universities);
            }
            JsonSerializer serializer1 = new JsonSerializer();
            List<Faculty> faculties = new List<Faculty>();
            using (StreamReader sr = File.OpenText(@"A:\repos\CW-2\CW-2\JsonFiles\Univer.json"))
            {
                faculties = (List<Faculty>)serializer1.Deserialize(sr, typeof(List<Faculty>));
            }
            foreach (var u in faculties)
            {
                Console.WriteLine(u);
            }
        }
    }
}
