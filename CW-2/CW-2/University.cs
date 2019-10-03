﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CW_2
{
    /// <summary>
    /// Class of university.
    /// </summary>
    class University
    {
        /// <summary>
        /// List property, list of the departments.
        /// </summary>
        public List<Department> Departments { get; } = new List<Department>();

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public University() { }

        #region Methods

        /// <summary>
        /// Method that add department to the list of departments.
        /// </summary>
        /// <param name="department">Department that need to add.</param>
        public void AddDepartment(Department department)
        {
            bool check = false;
            foreach (var tempDepartment in Departments)
            {
                if (tempDepartment.Equals(department) || Departments.Count >= 10) 
                {
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                Departments.Add(department);
            }
        }

        /// <summary>
        /// Method that display info about departments.
        /// </summary>
        public void DisplayDepartments()
        {
            foreach (var department in Departments)
            {
               Console.WriteLine(department.ToString());
               Console.WriteLine();
            }
        }

        #endregion

        public override string ToString()
        {
            StringBuilder departments = new StringBuilder();
            foreach (var department in Departments)
            {
                departments.Append(department + "\n");
            }
            return departments.ToString();
        }
    }
}
