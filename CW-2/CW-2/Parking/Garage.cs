using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of garage
    /// </summary>
    class Garage
    {
        /// <summary>
        /// Quantity of slots 
        /// </summary>
        [JsonProperty]
        public int QuantityOfSlots { get; private set; }

        /// <summary>
        /// Class constructor without params
        /// </summary>
        public Garage() { } 

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="quantityOfSlots">Quantity of slots</param>
        public Garage(int quantityOfSlots)
        {
            QuantityOfSlots = quantityOfSlots;
        }

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the garage.</returns>
        public override string ToString()
        {
            return "Quantity Of Slots:"+QuantityOfSlots;
        }
    }
}
