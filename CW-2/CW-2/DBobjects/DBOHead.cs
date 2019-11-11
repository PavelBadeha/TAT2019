
namespace CW_2
{
    /// <summary>
    /// Class of head data base object
    /// </summary>
    class DBOHead
    {
        public string Name { get; }
        public int Age { get; }
        public int CarNumber { get; }

        /// <summary>
        /// Id of the institute or the parking that has this head 
        /// </summary>
        public int InstituteId { get; }
        
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="carNumber"></param>
        /// <param name="instituteId"></param>
        public DBOHead(string name, int age, int carNumber, int instituteId)
        {
            Name = name;
            Age = age;
            CarNumber = carNumber;
            InstituteId = instituteId;
        }
    }
}
