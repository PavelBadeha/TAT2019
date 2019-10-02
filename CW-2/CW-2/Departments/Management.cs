using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace CW_2
{
    /// <summary>
    /// Class of management inheritor of Department.
    /// </summary>
    class Management :Department
    {
        public Head Head { get; }= new Head();

        public List<Employee> Employees { get; } = new List<Employee>();

        #region Constructors

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Management() : base() { }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name">Name of the faculty.</param>
        /// <param name="city">Name of the city.</param>
        /// <param name="street">Name of the street.</param>
        /// <param name="houseNumber">House number.</param>
        public Management(string name, string city, string street, string houseNumber) : base(name, city, street, houseNumber)
        { }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name">Name of the faculty.</param>
        /// <param name="address">Address.</param>
        public Management(string name, Address address) : base(name, address) { }

        public Management(string name, Address address, Head head) : base(name, address)
        {
            Head = head;
        }

        public Management(string name, Address address, List<Employee> employees) : base(name, address)
        {
            Employees.AddRange(employees);
        }
        #endregion

        public void AddEmployee(Employee employee)
        {
            bool check = true;
            foreach (var tempStudent in Employees)
            {
                if (tempStudent.Equals(employee))
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                Employees.Add(employee);
            }
        }
    }
}
