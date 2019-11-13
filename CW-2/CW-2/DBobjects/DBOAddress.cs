namespace CW_2
{
    /// <summary>
    /// Class of address data base object
    /// </summary>
    class DBOAddress
    {
        public string City { get; }
        public string Street { get; }
        public string HouseNumber { get; }

        /// <summary>
        /// Id of the house that has this address
        /// </summary>
        public int HouseId { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="address"></param>
        /// <param name="houseId"></param>
        public DBOAddress(string[] address,int houseId)
        {
            City = address[0];
            Street = address[1];
            HouseNumber = address[2];
            HouseId = houseId;
        }
    }
}
