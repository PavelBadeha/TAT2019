
namespace CW_2
{
    /// <summary>
    /// Class of parking data base object
    /// </summary>
    class DBOParking
    {
        public string Name { get; }

        /// <summary>
        /// Own Id
        /// </summary>
        public int ParkingId { get; }

        /// <summary>
        /// Id of the univesrity that has this parking
        /// </summary>
        public int UniversityId { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parkingId"></param>
        /// <param name="universityId"></param>
        public DBOParking(string name, int parkingId, int universityId)
        {
            Name = name;
            ParkingId = parkingId;
            UniversityId = universityId;
        }
    }
}
