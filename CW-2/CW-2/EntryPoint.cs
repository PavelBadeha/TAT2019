namespace CW_2
{
    /// <summary>
    ///Main class of the program. 
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point.
        /// </summary>
        static void Main()
        {
            Department faculty = new Faculty("RF","Minsk","Kurchatova","8");
            Department institute = new Institute("inst", "Gomel", "Kurchatova", "8");
            Department management = new Management("manag", "Brest", "Kurchatova", "8");
            Department facultyCopy = new Faculty("RF", "Minsk", "Kurchatova", "8");
            University university = new University();

            university.AddDepartment(faculty);
            university.AddDepartment(institute);
            university.AddDepartment(management);
            university.AddDepartment(facultyCopy);
            university.DisplayDepartments();

        }
    }
}
