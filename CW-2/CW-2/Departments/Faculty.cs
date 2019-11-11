using System.Collections.Generic;
using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of faculty inheritor of Department.
    /// </summary>
    class Faculty:Department
    {
        /// <summary>
        /// Dean of faculty
        /// </summary>
        [JsonProperty]
        public  Dean Dean { get; private set; } =new Dean();

        #region Constructor
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

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of faculty</param>
        /// <param name="address">Address of faculty</param>
        /// <param name="dean">Dean of faculty</param>
        public Faculty(string name, Address address, Dean dean) : base(name, address)
        {
            Dean = dean;
        }

        /// <summary>
        /// Class constuctor
        /// </summary>
        /// <param name="name">Name of faculty</param>
        /// <param name="address">Address of faculty</param>
        /// <param name="dean">Dean of faculty</param>
        /// <param name="students">Faculty contains this list of students</param>
        public Faculty(string name, Address address, Dean dean, List<Student> students) : base(name, address)
        {
            Dean = dean;
            foreach (var student in students)
            {
                AddMember(student);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Override method AddMember(Person person)
        /// </summary>
        /// <param name="person">Person which needed to add</param>
        public override void AddMember(Person person)
        {
            MaxSizeOfMemberList = 20;
            if (person is Student && MemberList.Count < MaxSizeOfMemberList)
            {
                base.AddMember(person);
            }
         
        }

        /// <summary>
        /// Method that can add list of students
        /// </summary>
        /// <param name="students">List of students that needed to add</param>
        public void AddMembers(List<Student> students)
        {
            foreach (var student in students)
            {
                AddMember(student);
            }
        }

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the faculty.</returns>
        public override string ToString()
        {
            return "Faculty\n" +base.ToString() + "\n" + Dean +"\nQuantity of student: "+MemberList.Count;
        }
        #endregion
    }
}
