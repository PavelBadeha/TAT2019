using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Abstract class of the department.
    /// </summary>
    abstract class Department
    {
        #region Properties

        /// <summary>
        /// Max size of member list
        /// </summary>
        [JsonProperty]
        public int MaxSizeOfMemberList { get; protected set; } =10;

        /// <summary>
        /// List of department members
        /// </summary>
        [JsonProperty]
        public List<Person> MemberList { get; private set; } =new List<Person>();

        /// <summary>
        /// String property, name of the department.
        /// </summary>
        [JsonProperty]
        public string Name { get; private set; } = String.Empty;

        /// <summary>
        /// Address property.
        /// </summary>
        [JsonProperty]
        public Address Address { get; private set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Department()
        {
            Address= new Address();
        }

        /// <summary>
        /// Class constructor .
        /// </summary>
        /// <param name="name">Name of the department.</param>
        /// <param name="address">Address.</param>
        public Department(string name,Address address)
        {
            this.Name = name;
            Address = address;
        }

        /// <summary>
        ///Class constructor.
        /// </summary>
        /// <param name="name">Name of the department.</param>
        /// <param name="city">Name of the city.</param>
        /// <param name="street">Name of the street.</param>
        /// <param name="houseNumber">House number.</param>
        public Department(string name, string city, string street, string houseNumber)
        {
            this.Name = name;
            Address = new Address(city,street,houseNumber);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the department.</returns>
        public override string ToString()
        {
            return "Name: " + Name + "." + " Address:" + Address;
        }

        /// <summary>
        /// Method that compare departments.
        /// </summary>
        /// <param name="objDepartment">Department to be compared with.</param>
        /// <returns>True if is equal and false if isn't equal.</returns>
        public override bool Equals(object objDepartment)
        {
            if (!(objDepartment is Department))
            {
                return false;
            }

            Department tempDepartment = (Department) objDepartment;
            
            return GetType() == tempDepartment.GetType() && Address.Equals(tempDepartment.Address) &&
                   Name.Equals(tempDepartment.Name);
        }

        /// <summary>
        /// Delegate of added member
        /// </summary>
        /// <param name="depName">Name of department</param>
        /// <param name="member">Name of member</param>
        public  delegate void AddedMember(string depName,string member);

        /// <summary>
        /// Event of added member
        /// </summary>
        public  event AddedMember EventAddedMember;

        /// <summary>
        /// Method that add member to department list
        /// </summary>
        /// <param name="person">Member which needed to add</param>
        public virtual void AddMember(Person person)
        {
            bool check = true;
            foreach (var member in MemberList)
            {
                if (member.Equals(person))
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                MemberList.Add(person);
            }

            EventAddedMember?.Invoke(Name,person.ToString());          
        }

        #endregion
    }
}
