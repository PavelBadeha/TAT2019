using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace CW_2
{
    /// <summary>
    /// Class of institute inheritor of Department.
    /// </summary>
    class Institute :Department
    {
        public  Head Head { get; }=new Head();

        #region Constructors

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Institute() { }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name">Name of the faculty.</param>
        /// <param name="city">Name of the city.</param>
        /// <param name="street">Name of the street.</param>
        /// <param name="houseNumber">House number.</param>
        public Institute(string name, string city, string street, string houseNumber) : base(name, city, street, houseNumber)
        { }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name">Name of the faculty.</param>
        /// <param name="address">Address.</param>
        public Institute(string name, Address address) : base(name, address) { }

        public Institute(string name, Address address, Head head) : base(name, address)
        {
            Head = head;
        }

        #endregion

        public override void AddMember(Person person)
        {
            if (person is Employee)
            {
                base.AddMember(person);
            }
        }

        public void AddMembers(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                AddMember(employee);
            }
        }
        public override string ToString()
        {
            return "Institute\n" + base.ToString() + "\n" + Head + "\nQuantity of employees:" + MemberList.Count;
        }
    }
}
