namespace CW_2
{
    /// <summary>
    /// Class of accountant data base object
    /// </summary>
    class DBOAccountant
    {
        /// <summary>
        /// Name of accountant
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Age of accountant
        /// </summary>
        public int Age { get; }

        /// <summary>
        ///Accountant work time per week
        /// </summary>
        public int HoursPerWeek { get; }

        /// <summary>
        /// Id of the management that has this accountant
        /// </summary>
        public int ManagementId { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="hoursPerWeek"></param>
        /// <param name="managementId"></param>
        public DBOAccountant(string name, int age, int hoursPerWeek, int managementId)
        {
            Name = name;
            Age = age;
            HoursPerWeek = hoursPerWeek;
            ManagementId = managementId;
        }

    }
}
