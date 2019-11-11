using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of employee
    /// </summary>
    class Employee:Person
    {
        /// <summary>
        /// Employee's salary
        /// </summary>
        [JsonProperty]
        public float Salary { get;private set; } = 150;

        /// <summary>
        /// Class constructors wothout params
        /// </summary>
        public Employee() { }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of employee</param>
        /// <param name="age">Age of employee</param>
        /// <param name="salary">Salary of employee</param>
        public Employee(string name, int age, float salary) : base(name, age)
        {
            Salary = salary;
        }


        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the employee.</returns>
        public override string ToString()
        {
            return "Employee\n" +base.ToString()+" Salary:"+Salary;
        }
    }
}
