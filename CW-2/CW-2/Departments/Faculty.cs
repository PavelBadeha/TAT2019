using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CW_2
{
    /// <summary>
    /// Class of faculty inheritor of Department.
    /// </summary>
    class Faculty:Department
    {
        public  Dean Dean { get; }=new Dean();

        public List<Student> Students { get; } = new List<Student>();

        #region Constructors

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Faculty() : base() { }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name">Name of the faculty.</param>
        /// <param name="city">Name of the city.</param>
        /// <param name="street">Name of the street.</param>
        /// <param name="houseNumber">House number.</param>
        public Faculty(string name, string city, string street, string houseNumber) :base(name,  city,  street,  houseNumber)
        { }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name">Name of the faculty.</param>
        /// <param name="address">Address.</param>
        public Faculty(string name, Address address) : base(name, address) { }

        #endregion

        public void AddStudent(Student student)
        {
            bool check = true;
            foreach (var tempStudent in Students)
            {
                if (tempStudent.Equals(student))
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                Students.Add(student);
            }
        }
    }
}
