namespace CW_2
{
    /// <summary>
    /// Class of institute inheritor of Department.
    /// </summary>
    class Institute :Department
    {
        #region Constructors

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Institute() : base() { }

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

        #endregion
    }
}
