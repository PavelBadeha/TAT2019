
namespace CW_2
{
    /// <summary>
    /// Class of student data base object
    /// </summary>
    class DBOStudent
    {
        public string Name { get; }
        public int Age { get; }
        public int[] Marks { get; } = new int[5];

        /// <summary>
        /// Id of the faculty that has this student
        /// </summary>
        public int FacultyId { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="marks"></param>
        /// <param name="facultyId"></param>
        public DBOStudent(string name,int age,int[]marks,int facultyId)
        {
            Name = name;
            Age = age;
            marks.CopyTo(Marks, 0);
            FacultyId = facultyId;
        }
    }
}
