namespace CW_2
{
    /// <summary>
    /// Class of car data base object
    /// </summary>
    class DBOCar
    {
        public string Brand { get; }
        public int Number { get; }

        /// <summary>
        /// Id of the parkings that has this car
        /// </summary>
        public int ParkingId { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="number"></param>
        /// <param name="brand"></param>
        /// <param name="parkingId"></param>
        public DBOCar(int number,string brand,int parkingId)
        {
            Brand = brand;
            Number = number;
            ParkingId = parkingId;
        }
    }
}
