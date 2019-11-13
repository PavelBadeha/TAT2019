namespace CW_2
{
    /// <summary>
    /// Class of employee data base object
    /// </summary>
    class DBOEmployee
    {
        public string Name { get; }
        public int Age { get; }
        public int Salary{ get; }

        /// <summary>
        /// Id of the institute that has this employee
        /// </summary>
        public int InstituteId { get; }
        public DBOEmployee(string name, int age, int salary, int insituteId)
        {
            Name = name;
            Age = age;
            Salary = salary;
            InstituteId = insituteId;
        }
    }
}
