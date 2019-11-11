using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of accountant
    /// </summary>
    class Accountant:Person
    {
        /// <summary>
        /// Week work time
        /// </summary>
        [JsonProperty]
        public int HoursPerWeek { get; private set; } = 40;

        #region Constructors
        /// <summary>
        /// Class constructor without params
        /// </summary>
        public Accountant() { }

        /// <summary>
        /// Class constructors
        /// </summary>
        /// <param name="name">Name of accountant</param>
        /// <param name="age">Age of accountant</param>
        /// <param name="hoursPerWeek">Week work time</param>
        public Accountant(string name, int age, int hoursPerWeek) : base(name, age)
        {
            HoursPerWeek = hoursPerWeek;
        }
        #endregion

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the accountant.</returns>
        public override string ToString()
        {
            return "Accountant\n" +base.ToString()+" Hours per week:"+ HoursPerWeek ;
        }      
    }
}
