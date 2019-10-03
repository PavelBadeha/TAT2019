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

        public Faculty(string name, Address address, Dean dean) : base(name, address)
        {
            Dean = dean;
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

        public override string ToString()
        {
            return "Faculty\n" +base.ToString() + "\n" + Dean +"\nQuantity of student: "+MemberList.Count;
        }
    }
}
