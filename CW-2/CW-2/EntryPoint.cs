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
            Person head = new Head("Ighor Kheidorov",50,7777);
            Person dean = new Dean("Maloy",50,602);
            Person head2 = new Head("Korol",45,9999);
            Address address = new Address("Minsk", "Kurchatova", "8");
            Faculty faculty = new Faculty("RF",address,(Dean)dean);
            Institute institute = new Institute("inst",address,(Head)head);
            Management management = new Management("manage",address,(Head)head);
            Faculty facultyCopy = new Faculty("RF",address,(Dean)dean);
            University university = new University();

            Student pasha = new Student("Pasha", 19);
            Accountant accountant = new Accountant("Petrova",50,40);
            faculty.AddStudent(pasha);
            management.AddAccountant(accountant);

            university.AddDepartment(faculty);
            university.AddDepartment(institute);
            university.AddDepartment(management);
            university.AddDepartment(facultyCopy);
            university.DisplayDepartments();

        }
    }
}
