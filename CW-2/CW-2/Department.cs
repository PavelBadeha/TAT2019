using System;

namespace CW_2
{
    /// <summary>
    ///Class of the department.
    /// </summary>
    class Department
    {
        #region Properties

        /// <summary>
        /// String property, name of the department.
        /// </summary>
        public string Name { get; set; } = String.Empty;

        /// <summary>
        /// Address property.
        /// </summary>
        public Address Address { get; set; }

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
            return "Name: " + Name + "." + " Address:" + Address.ToString();
        }

        /// <summary>
        /// Method that compare departments.
        /// </summary>
        /// <param name="objDepartment">Department to be compared with.</param>
        /// <returns>True if is equal and false if isn't equal.</returns>
        public bool IsEqual(Department objDepartment)
        {
            return this.GetType() == objDepartment.GetType() && this.Address.Equals(objDepartment.Address) &&
                   this.Name.Equals(objDepartment.Name);
        }

        #endregion
    }
}
