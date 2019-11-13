using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of dean
    /// </summary>
    class Dean:Person
    {
        /// <summary>
        /// Number of dean's office
        /// </summary>
        [JsonProperty]
        public int Office { get; private set; }

        /// <summary>
        /// Class constructor without params
        /// </summary>
        public Dean() { }

        /// <summary>
        /// Class constructors
        /// </summary>
        /// <param name="name">Name of dean</param>
        /// <param name="age">Age of dean</param>
        /// <param name="office">Number of dean's office</param>
        public Dean(string name, int age, int office) : base(name, age)
        {
            Office = office;
        }

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the dean.</returns>
        public override string ToString()
        {
            return "Dean\n"+base.ToString()+" Office:"+Office;
        }
    }
}
