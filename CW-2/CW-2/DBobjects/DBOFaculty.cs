namespace CW_2
{
    /// <summary>
    /// Class of faculty data base object
    /// </summary>
    class DBOFaculty
    {
        public string Name { get; }

        /// <summary>
        /// Own Id
        /// </summary>
        public int FacultyId { get; }

        /// <summary>
        /// Id of the university that has this faculty
        /// </summary>
        public int UniversityId { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="facultyId"></param>
        /// <param name="universityId"></param>
        public DBOFaculty(string name, int facultyId,int universityId)
        {
            Name = name;
            FacultyId = facultyId;
            UniversityId = universityId;
        }
    }
}
