
namespace CW_2
{
    /// <summary>
    /// Class of garage data base object
    /// </summary>
    class DBOGarage
    {
        public int QuantityOfSlots { get; }

        /// <summary>
        /// Id of the parking that has this garage
        /// </summary>
        public int ParkingId { get; }
        
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="freeSlots"></param>
        /// <param name="parkingId"></param>
        public DBOGarage(int freeSlots,int parkingId)
        {
            QuantityOfSlots = freeSlots;
            ParkingId = parkingId;
        }
    }
}
