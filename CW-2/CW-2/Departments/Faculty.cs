using System.Collections.Generic;
using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of faculty inheritor of Department.
    /// </summary>
    class Faculty:Department
    {
        [JsonProperty]
        public  Dean Dean { get; private set; } =new Dean();

        public List<Student> Students { get; private set; } = new List<Student>();
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

        public Faculty(string name, Address address, Dean dean) : base(name, address)
        {
            Dean = dean;
        }

        public Faculty(string name, Address address, Dean dean, List<Student> students) : base(name, address)
        {
            Dean = dean;
            foreach (var student in students)
            {
                AddMember(student);
            }
        }
        #endregion

      
        public override void AddMember(Person person)
        {
            MaxSizeOfMemberList = 20;
            if (person is Student && MemberList.Count < MaxSizeOfMemberList)
            {
                base.AddMember(person);
            }
         
        }

        public void AddMembers(List<Student> students)
        {
            foreach (var student in students)
            {
                AddMember(student);
            }
        }
        public override string ToString()
        {
            return "Faculty\n" +base.ToString() + "\n" + Dean +"\nQuantity of student: "+MemberList.Count;
        }
    }
}
