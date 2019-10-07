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
            XmlProvider xmlProvider=new XmlProvider("XmlFiles/DepartmentsXml.xml");
            UniversityCreator creator = new UniversityCreator();
            University university = creator.GetUniversity(xmlProvider);
            university.DisplayDepartments();
        }
    }
}
                                                                                                                                                                       