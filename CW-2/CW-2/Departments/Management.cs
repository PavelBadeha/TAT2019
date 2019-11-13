using System.Collections.Generic;
using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of management inheritor of Department.
    /// </summary>
    class Management :Department
    {
        /// <summary>
        /// Head of management
        /// </summary>
        [JsonProperty]
        public Head Head { get; private set; } = new Head();

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

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of management</param>
        /// <param name="address">Address of management</param>
        /// <param name="head">Head of management</param>
        /// <param name="accountants">Management contains this list of accountants</param>
        public Management(string name, Address address, Head head,List<Accountant> accountants) : base(name, address)
        {
            Head = head;
            AddMembers(accountants);
        }

        #endregion

        #region Methods
        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the management.</returns>
        public override string ToString()
        {
            return "Management\n" + base.ToString() + "\n" + Head + "\nQuantity of accountants:" + MemberList.Count;
        }

        /// <summary>
        /// Override method AddMember(Person person)
        /// </summary>
        /// <param name="person">Personn which needed to add</param>
        public override void AddMember(Person person)
        {
            if (person is Accountant)
            {
                base.AddMember(person);
            }
        }


        /// <summary>
        /// Method that can add list of accountants to member list
        /// </summary>
        /// <param name="accountants">List of accountants which needed to add</param>
        public void AddMembers(List<Accountant> accountants)
        {
            foreach (var accountant in accountants)
            {
                AddMember(accountant);
            }
        }
        #endregion
    }
}
