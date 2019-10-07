﻿using System.Collections.Generic;

namespace CW_2
{
    /// <summary>
    /// Class of management inheritor of Department.
    /// </summary>
    class Management :Department
    {
        public Head Head { get; }= new Head();

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

        public Management(string name, Address address, List<Accountant> accountants) : base(name, address)
        {
            MemberList.AddRange(accountants);
        }
        #endregion

        public override string ToString()
        {
            return "Management\n" + base.ToString() + "\n" + Head + "\nQuantity of accountants:" + MemberList.Count;
        }

        public override void AddMember(Person person)
        {
            if (person is Accountant)
            {
                base.AddMember(person);
            }
        }

        public void AddMembers(List<Accountant> accountants)
        {
            foreach (var accountant in accountants)
            {
                AddMember(accountant);
            }
        }
    }
}