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
            University university = new University("XmlFiles/DepartmentsXml.xml");
            Faculty faculty = new Faculty("RF", "Minsk", "Kurchatova", "8");
           XmlParser xmlParser = new XmlParser("XmlFiles/RfFaculty.xml");
           Faculty rfFaculty = xmlParser.GetFacultyFromXml(xmlParser.xRoot);
            //university.DisplayDepartments();
            faculty.AddStudentsFromXml("XmlFiles/StudentsForRF.xml");
            Console.WriteLine(rfFaculty);
        }
    }
}
