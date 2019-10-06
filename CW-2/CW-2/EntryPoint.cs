using System;
using System.Xml;

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
            XmlParser xmlParser = new XmlParser("XmlFiles/DepartmentsXml.xml");
            Faculty faculty = new Faculty("RF", "Minsk", "Kurchatova", "8");
           // faculty.AddMembers(xmlParser.GetListOfStudents(xmlParser.xRoot));
           University university = xmlParser.GetUniversityFromXml();
           university.DisplayDepartments();
           //Person head = new Head("Ighor Kheidorov",50,7777);
           //Person dean = new Dean("Maloy",50,602);
           //Person head2 = new Head("Korol",45,9999);
           //Address address = new Address("Minsk", "Kurchatova", "8");
           //Faculty faculty = new Faculty("RF",address,(Dean)dean);
           //Institute institute = new Institute("inst",address,(Head)head);
           //Management management = new Management("manage",address,(Head)head);
           //Faculty facultyCopy = new Faculty("RF",address,(Dean)dean);
           //University university = new University();

           //Student pasha = new Student("Pasha", 19,new[ ]{4,4,4,4,5});
           //Accountant accountant = new Accountant("Petrova",50,40);

           //faculty.AddMember(pasha);
           //management.AddMember(accountant);
           //university.AddDepartment(faculty);
           //university.AddDepartment(institute);
           //university.AddDepartment(management);
           //university.AddDepartment(facultyCopy);
           //university.DisplayDepartments();

           //Console.WriteLine(faculty.MemberList[0]+"\n");
           //Console.WriteLine(management.MemberList[0]);

        }
    }
}
