

namespace CW_2
{
    /// <summary>
    /// Class of university data base object
    /// </summary>
    class DBOUniversity
    {
        public string Name { get; }

        /// <summary>
        /// Own Id
        /// </summary>
        public int UniversityId { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="universityId"></param>
        public DBOUniversity(string name, int universityId)
        {
            Name = name;
            UniversityId = universityId;
        }
    }
}
