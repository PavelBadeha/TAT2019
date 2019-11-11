using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of head
    /// </summary>
    class Head:Person
    {
        /// <summary>
        /// Head's car number
        /// </summary>
        [JsonProperty]
        public int CarNumber { get; private set; }

        /// <summary>
        /// Class constructor without params
        /// </summary>
        public Head() { }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of head</param>
        /// <param name="age">Age of head</param>
        /// <param name="carNumber">Head's car number</param>
        public Head(string name, int age,int carNumber) : base(name, age)
        {
            CarNumber = carNumber;
        }

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the head.</returns>
        public override string ToString()
        {
            return "Head\n" + base.ToString()+" Car number:"+CarNumber;
        }
    }
}
