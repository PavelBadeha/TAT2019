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
        [JsonProperty]
        public string Name { get;private set; }

        /// <summary>
        /// List property, list of the departments.
        /// </summary>
        [JsonProperty]
        public List<Department> Departments { get; private set; } = new List<Department>();

        [JsonProperty]
        public List<Parking> Parkings { get; private set; } =new List<Parking>();

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public University(){ }

        public University(string name)
        {
            Name = name;           
        }
        public University(string name,List<Department> departments,List<Parking> parkings)
        {
            Name = name;
            Departments = departments;
            Parkings = parkings;
        }
        #region Methods

        private void AddedNewMember(string depName,string member)
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
            department.EventAddedMember += AddedNewMember;
        }

        public void AddDepartments(List<Department> departments)
        {
            foreach (var department in departments)
            {
                AddDepartment(department);
            }
        }

        public void AddParking(Parking parking)
        {
            Parkings.Add(parking);
        }

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
