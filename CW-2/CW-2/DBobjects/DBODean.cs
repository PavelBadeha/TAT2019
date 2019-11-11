namespace CW_2
{
    /// <summary>
    /// Class of dean data base object
    /// </summary>
    class DBODean
    {
        public string Name { get; }
        public int Age { get; }
        public int Office { get; }

        /// <summary>
        /// Id of the faculty that has this dean
        /// </summary>
        public int FacultyId { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="office"></param>
        /// <param name="facultyId"></param>
        public DBODean(string name, int age, int office, int facultyId)
        {
            Name = name;
            Age = age;
            Office = office;
            FacultyId = facultyId;
        }
    }
}
