using System;
using System.Collections.Generic;

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
        public List<Department> Departments = new List<Department>();

        /// <summary>
        /// Parametersless constructor.
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
                if (tempDepartment.IsEqual(department))
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
    }
}
