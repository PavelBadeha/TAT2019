
namespace CW_2
{
    /// <summary>
    /// Class of institute data base object
    /// </summary>
    class DBOInstitute
    {
        public string Name { get; }

        /// <summary>
        /// Own ID
        /// </summary>
        public int InstituteId { get; }

        /// <summary>
        /// Id of the univesrity that has this institute
        /// </summary>
        public int UniversityId { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="instituteId"></param>
        /// <param name="universityId"></param>
        public DBOInstitute(string name, int instituteId, int universityId)
        {
            Name = name;
            InstituteId = instituteId;
            UniversityId = universityId;
        }
    }
}
