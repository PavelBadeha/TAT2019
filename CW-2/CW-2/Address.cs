using System;

namespace CW_2
{
    /// <summary>
    ///Class of the address.
    /// </summary>
    class Address
    {
        #region Properties

        /// <summary>
        /// String property, name of the city.
        /// </summary>
        public string City { get; } = String.Empty;

        /// <summary>
        /// String property, name of the street.
        /// </summary>
        public string Street { get;  } = String.Empty;

        /// <summary>
        /// String property, The house number.
        /// </summary>
        public string HouseNumber { get;} = String.Empty;

        #endregion

        #region Constructors

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="city">Name of the city.</param>
        /// <param name="street">Name of the street.</param>
        /// <param name="houseNumber">House number.</param>
        public Address(string city, string street, string houseNumber)
        {
            Street = street;
            City = city;
            HouseNumber = houseNumber;
        }

        public Address(string[] address)
        {
            City = address[0];
            Street = address[1];
            HouseNumber = address[2];
        }
        #endregion

        #region Methods

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the address.</returns>
        public override string ToString()
        {
            return City + "," + Street + "," + HouseNumber + ".";
        }

        /// <summary>
        /// Method that overrides method "Equals(object obj)".
        /// </summary>
        /// <param name="obj">Object to be compares with.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Address temp;
            if (obj is Address)
            {
                temp = (Address) obj;
            }
            else 
                temp = new Address();

            if (this.Street.Equals(temp.Street) && this.City.Equals(temp.City) &&
                this.HouseNumber.Equals(temp.HouseNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
