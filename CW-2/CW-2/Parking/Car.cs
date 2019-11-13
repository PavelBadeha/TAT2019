using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of car
    /// </summary>
    class Car
    {
        /// <summary>
        /// Number of car
        /// </summary>
        [JsonProperty]
        public int Number { get; private set; }

        /// <summary>
        /// Brand of ca
        /// </summary>
        [JsonProperty]
        public string Brand { get; private set; } = string.Empty;

        /// <summary>
        /// Class constructor without params
        /// </summary>
        public Car() { }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="number">Number of car</param>
        /// <param name="brand">Brand of car</param>
        public Car(int number,string brand)
        {
            Number = number;
            Brand = brand;
        }
    }
}
