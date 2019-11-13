using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CW_2
{ 
    /// <summary>
    /// Class of university.
    /// </summary>
    class University
    {
        #region Properties

        /// <summary>
        /// Name property
        /// </summary>
        [JsonProperty]
        public string Name { get;private set; }

        /// <summary>
        /// List property, list of the departments.
        /// </summary>
        [JsonProperty]
        public List<Department> Departments { get; private set; } = new List<Department>();

        /// <summary>
        /// List property, list of the parkings.
        /// </summary>
        [JsonProperty]
        public List<Parking> Parkings { get; private set; } = new List<Parking>();
        #endregion

        #region Constructors
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public University() { }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of the University</param>
        public University(string name)
        {
            Name = name;           
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of the University</param>
        /// <param name="departments">List of departments</param>
        /// <param name="parkings">List of parkings</param>
        public University(string name,List<Department> departments,List<Parking> parkings)
        {
            Name = name;
            Departments = departments;
            Parkings = parkings;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Method that display info about new member of departments
        /// </summary>
        /// <param name="depName">Name of the department</param>
        /// <param name="member">Name of the new member</param>
        private void DisplayInfoAboutNewMember(string depName,string member)
        {
            Console.WriteLine($"{Name}:\n{depName} added new member\n{member} ");
        }

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
            department.EventAddedMember += DisplayInfoAboutNewMember;
        }

        /// <summary>
        /// Method that add departments to the list of departments.
        /// </summary>
        /// <param name="departments">List of departments that need to add.</param>
        public void AddDepartments(List<Department> departments)
        {
            foreach (var department in departments)
            {
                AddDepartment(department);
            }
        }

        /// <summary>
        /// Method that add parking to the list of parkings.
        /// </summary>
        /// <param name="parking">Parking that need to add.</param>
        public void AddParking(Parking parking)
        {
            Parkings.Add(parking);
        }

        /// <summary>
        /// Method that add parkings to the list of parkings.
        /// </summary>
        /// <param name="parkings">List of parkings that need to add.</param>
        public void AddParkings(List<Parking> parkings)
        {
            foreach (var parking in parkings)
            {
                AddParking(parking);
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

            foreach (var parking in Parkings)
            {
                Console.WriteLine(parking);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the university.</returns>
        public override string ToString()
        {
            StringBuilder departmentsStringBuilder = new StringBuilder();
            StringBuilder parkingStringBuilder = new StringBuilder();
            foreach (var department in Departments)
            {
                departmentsStringBuilder.Append(department + "\n");
            }
            foreach (var parking in Parkings)
            {
                parkingStringBuilder.Append(parking + "\n");
            }
            return Name + "\n" + departmentsStringBuilder + parkingStringBuilder;
        }
        #endregion
    }
}
