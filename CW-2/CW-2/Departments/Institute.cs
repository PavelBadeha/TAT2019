using System.Collections.Generic;
using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of institute inheritor of Department.
    /// </summary>
    class Institute :Department
    {
        /// <summary>
        /// Head of institute
        /// </summary>
        [JsonProperty]
        public  Head Head { get; private set; } =new Head();

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

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of institute</param>
        /// <param name="address">Address of institute</param>
        /// <param name="head">Head of institute</param>
        /// <param name="employees">Institute contains this list of employees</param>
        public Institute(string name, Address address, Head head,List<Employee> employees) : base(name, address)
        {
            Head = head;
            AddMembers(employees);
        }

        #endregion

        #region Methods
        /// <summary>
        /// Override method AddMember(Person person)
        /// </summary>
        /// <param name="person">Person which needed to add</param>
        public override void AddMember(Person person)
        {
            if (person is Employee)
            {
                base.AddMember(person);
            }
        }

        /// <summary>
        /// Method that can add list of employees to member list
        /// </summary>
        /// <param name="employees">List of employees which needed to add</param>
        public void AddMembers(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                AddMember(employee);
            }
        }

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the institute.</returns>
        public override string ToString()
        {
            return "Institute\n" + base.ToString() + "\n" + Head + "\nQuantity of employees:" + MemberList.Count;
        }
        #endregion
    }
}
