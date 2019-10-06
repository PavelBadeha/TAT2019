﻿using System;
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
            University university = new University("XmlFiles/DepartmentsXml.xml");
            Faculty faculty = new Faculty("RF", "Minsk", "Kurchatova", "8");
           
            university.DisplayDepartments();
            faculty.AddStudentsFromXml("XmlFiles/StudentsForRF.xml");
            Console.WriteLine(faculty);
        }
    }
}
